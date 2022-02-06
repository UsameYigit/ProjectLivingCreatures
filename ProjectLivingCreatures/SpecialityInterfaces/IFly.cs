using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLivingCreatures.SpecialityInterfaces
{
    interface IFly : IGlide
    {
        int FlyingTime { get; set; }
        string Fly();
    }
}
