using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLivingCreatures.LivingCreatureClasses
{
    class Invertebrate : Animal
    {
        public Invertebrate()
        {
            this.AnimalType = Animals.AnimalTypes.Invertebrates;
        }

        public sealed override string Digest()
        {
            return "They're mostly primitive type animals So their digest is primitive as well.";
        }
    }
}
