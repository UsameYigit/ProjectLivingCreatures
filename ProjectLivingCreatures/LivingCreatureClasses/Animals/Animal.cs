using ProjectLivingCreatures.LivingCreatureClasses.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLivingCreatures
{
    abstract class Animal : LivingCreature
    {
        AnimalTypes _animalType;
        public AnimalTypes AnimalType
        {
            get => _animalType;
            set => _animalType = value;
        }

        public Animal()
        {
            this.Type = Types.Animal;
        }

        public Animal(string Name, int Age, double Weight, double Height) : base(Name, Age, Weight, Height)
        {
            this.Type = Types.Animal;
        }

        public abstract string Digest();

        public override string Breath()
        {
            return "Some has primitive while others have so complex breathing solutions.";
        }

        public override string Move()
        {
            return "We have so many ways to move on.";
        }

        public override string Reproduce()
        {
            return "Almost every sub-category have their own way of reproducing.";
        }
    }
}
