using ProjectLivingCreatures.LivingCreatureClasses.Animals.Invertebrates.WithJointedLegs;
using ProjectLivingCreatures.SpecialityInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLivingCreatures.LivingCreatureClasses.Animals.Vertebrates.ColdBloodeds.Amphibians
{
    class Amphibians : ColdBlooded, IMetamorphosis, IWalk
    {
        public int LegNumbers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Metamorph()
        {
            throw new NotImplementedException();
        }

        public string Walk()
        {
            throw new NotImplementedException();
        }
    }
}
