using ProjectLivingCreatures.SpecialityInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLivingCreatures.LivingCreatureClasses.Animals.Vertebrates.ColdBloodeds.Reptiles
{
    class Crocodile : Reptile, IWalk
    {
        public int LegNumbers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Walk()
        {
            throw new NotImplementedException();
        }
    }
}
