using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01
{
    internal class Zvíře
    {
        public string Druh { get; set; }

        public Zvíře(string druh)
        {
            Druh = druh;
        }

        public virtual string UdelejZvuk()
        {
            return "";
        }
    }
}
