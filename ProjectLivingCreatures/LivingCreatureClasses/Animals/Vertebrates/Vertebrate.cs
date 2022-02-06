using ProjectLivingCreatures.LivingCreatureClasses.Animals;
using ProjectLivingCreatures.SpecialityInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLivingCreatures.LivingCreatureClasses.Animals.Vertebrates
{
    class Vertebrate : Animal
    {
        double _bloodPressure;
        public double BloodPressure
        {
            get => _bloodPressure;
            set
            {
                if (value < 12)
                    _bloodPressure = 12 * 2;
                else
                    _bloodPressure = value *1.2;
            }
        }

        public Vertebrate() 
        {
            this.AnimalType = AnimalTypes.Vertebrates;
        }

        public Vertebrate(string Name, int Age, double Weight, double Height, double BloodPressure) : base(Name, Age, Weight, Height)
        {
            this.BloodPressure = BloodPressure;
            this.AnimalType = AnimalTypes.Vertebrates;
        }

        public override string Digest()
        {
            return "They can digest.";
        }

    }
}
