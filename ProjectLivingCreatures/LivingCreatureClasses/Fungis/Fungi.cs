using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectLivingCreatures.LivingCreatureClasses.Fungi
{
    class Fungi : LivingCreature
    {
        int _toxicityLevel;
        public int ToxicityLevel
        {
            get => _toxicityLevel;
            set
            {
                if(120 < value)
                {
                    MessageBox.Show("This level is so dangerous for evey other creature");
                }
                _toxicityLevel = value;
            }
        }
        public Fungi()
        {
            this.Type = Types.Fungi;
        }

        public override string Breath()
        {
            return "Like every living beings it'snot impossible for fungis to live without breathing.";
        }

        public override string Move()
        {
            return "Fungis can move minimistically like plants.";
        }

        public override string Reproduce()
        {
            return "Fungis can reproduce via spores.";
        }
    }
}
