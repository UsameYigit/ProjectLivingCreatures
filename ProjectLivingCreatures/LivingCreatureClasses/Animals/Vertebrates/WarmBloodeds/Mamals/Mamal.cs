using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLivingCreatures.LivingCreatureClasses.Animals.Vertebrates.WarmBloodeds.Mamals
{
    class Mamal : WarmBlooded
    {
        double _temprature;
        public double Temprature
        {
            get => _temprature;
            set => _temprature = value;
        }
        public Mamal()
        {
        }

        public Mamal(string Name, int Age, double Weight, double Height, double BloodPressure, int LegNumbers, double Temprature) : base(Name, Age, Weight, Height, BloodPressure, LegNumbers)
        {
            this.Temprature = Temprature;
        }

        public override string ToString()
        {
            return "This is Mamal class but will have same specifications like human as well, Name: " + this.Name + " Age: " + this.Age + " Weight: " + this.Weight + " Height: " + this.Height + " BloodPressure: " + this.BloodPressure + " LegNumbers: " + this.LegNumbers + " Temprature: " + this.Temprature;
        }

        public override string Move()
        {
            return "Swim to move, Run to move, Fly to move.";
        }
    }
}
