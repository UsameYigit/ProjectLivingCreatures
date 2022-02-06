using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLivingCreatures
{
    enum Types { Plant, Animal, Bacteria, Fungi};
    abstract class LivingCreature
    {
        string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        int _age;
        public int Age
        {
            get => _age;
            set => _age = value;
        }
        Types _type;
        public Types Type
        {
            get => _type;
            set => _type = value;
        }
        double _weight;
        public double Weight
        {
            get => _weight;
            set => _weight = value;
        }
        double _height;
        public double Height
        {
            get => _height;
            set => _height = value;
        }
        public LivingCreature()
        {

        }
        public LivingCreature(string Name, int Age, double Weight, double Height)
        {
            this.Name = Name;
            this.Age = Age;
            this.Weight = Weight;
            this.Height = Height;
        }


        public abstract string Reproduce();
        public abstract string Breath();
        public abstract string Move();
        public virtual string UseEnergy()
        {
            return "It's a way of living for every creature.";
        }

    }
}
