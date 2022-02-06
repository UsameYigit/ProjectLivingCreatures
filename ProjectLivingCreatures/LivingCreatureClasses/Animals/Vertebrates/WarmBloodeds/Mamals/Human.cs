using ProjectLivingCreatures.LivingCreatureClasses.Animals.Vertebrates;
using ProjectLivingCreatures.LivingCreatureClasses.Animals.Vertebrates.WarmBloodeds.Mamals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLivingCreatures
{
    class Human : Mamal
    {
        public Human()
        {
        }

        public Human(string Name, int Age, double Weight, double Height, double BloodPressure, int LegNumbers, double Temprature) : base(Name, Age, Weight, Height, BloodPressure, LegNumbers, Temprature)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override string Digest()
        {
            return "Human digesting yeea!";
        }

        public string Walk()
        {
            return "Walking man.";
        }
    }
}
