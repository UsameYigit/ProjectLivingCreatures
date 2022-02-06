using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLivingCreatures.SpecialityInterfaces
{
    interface IGlide
    {
        int WingWidth { get; set; }

        string Glide();
    }
}
