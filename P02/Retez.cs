using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02
{
    internal class Retez
    {
        protected string veta;
        protected int cislo;

        public virtual string Veta
        {
            get
            {
                return veta;
            }
            set
            {
                veta = value;
                if (veta != "")
                {
                    veta = veta.Substring(0, 1).ToUpper() + veta.Substring(1);
                    if (veta[veta.Length - 1] != '.')
                    {
                        veta += '.';
                    }
                }
            }
        }

        public Retez(string veta)
        {
            Veta = veta;
            cislo = 1;
        }

        public Retez(string veta, int cislo)
        {
            Veta = veta;
            this.cislo = cislo;
        }

        public override string ToString()
        {
            return Veta;
        }

        public virtual void Zkrat()
        {
            string[] slova = Veta.Split(' ');
            slova = slova.Take(cislo).ToArray();

            Veta = string.Join(" ", slova);
        }
    }
}
