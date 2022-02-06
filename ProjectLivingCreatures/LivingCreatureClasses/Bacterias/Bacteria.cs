using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLivingCreatures.LivingCreatureClasses.Bacterias
{
    class Bacteria : LivingCreature
    {
        public Bacteria()
        {
            this.Type = Types.Bacteria;
        }
        public override string Breath()
        {
           return "Yes they breath.";
        }

        public override string Move()
        {
            return "If your I could see them you could've seen their movements.";
        }

        public override string Reproduce()
        {
            return "they reproduce via multiplying.";
        }
    }
}
