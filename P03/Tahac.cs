using P07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03
{
    internal class Tahac : NakladniAuto
    {


        public Tahac(string spz, int nosnost, int nosnostVlečky) : base(spz, nosnost)
        {
            this.nosnost += nosnostVlečky;
        }
    }
}
