using ProjectLivingCreatures.SpecialityInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLivingCreatures.LivingCreatureClasses.Animals.Vertebrates.WarmBloodeds.Birds
{
    class Bird : WarmBlooded, IGlide
    {
        public int WingWidth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Glide()
        {
            throw new NotImplementedException();
        }
    }
}
