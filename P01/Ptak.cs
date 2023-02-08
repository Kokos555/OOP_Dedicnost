using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01
{
    class Ptak : Zvíře
    {

        public Ptak(string druh) : base(druh)
        {

        }

        public override string UdelejZvuk()
        {
            return "Pí pí";
        }
    }
}
