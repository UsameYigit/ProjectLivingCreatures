using ProjectLivingCreatures.SpecialityInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLivingCreatures.LivingCreatureClasses.Animals.Invertebrates.WithJointedLegs
{
    class WithJointedLeg : Invertebrate, IWalk
    {
        public int LegNumbers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Walk()
        {
            throw new NotImplementedException();
        }
    }
}
