using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01
{
    internal class Zpevny_ptak : Ptak
    {
        public Zpevny_ptak(string druh) : base(druh)
        {

        }

        public override string UdelejZvuk()
        {
            return string.Format($"{base.UdelejZvuk()} la la");
        }

    }
}
