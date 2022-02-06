using ProjectLivingCreatures.SpecialityInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLivingCreatures.LivingCreatureClasses.Animals.Vertebrates.ColdBloodeds.Fishes
{
    class Fish : WarmBlooded, IBreathUnderWater
    {
        public string BreathUnderWater()
        {
            throw new NotImplementedException();
        }
    }
}
