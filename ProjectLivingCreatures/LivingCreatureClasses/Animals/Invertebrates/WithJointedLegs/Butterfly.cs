using ProjectLivingCreatures.SpecialityInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLivingCreatures.LivingCreatureClasses.Animals.Invertebrates.WithJointedLegs
{
    class Butterfly : WithJointedLeg, IFly
    {

        public int FlyingTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int WingWidth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Fly()
        {
            throw new NotImplementedException();
        }

        public string Glide()
        {
            throw new NotImplementedException();
        }
    }
}
