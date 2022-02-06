using ProjectLivingCreatures.SpecialityInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLivingCreatures.LivingCreatureClasses.Animals.Vertebrates
{
    class WarmBlooded : Vertebrate, IWalk
    {
        int _legNumbers;
        public int LegNumbers { get => _legNumbers; set => _legNumbers = value; }

        public WarmBlooded()
        {
        }

        public WarmBlooded(string Name, int Age, double Weight, double Height, double BloodPressure, int LegNumbers) : base(Name, Age, Weight, Height, BloodPressure)
        {
            this.LegNumbers = LegNumbers;
        }

        public override string Breath()
        {
            return "Breath via lungs.";
        }


        public string Walk()
        {
            return "Every warm blooded animals can walk";
        }
    }
}
