using P02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02
{
    internal class RetezDalsi : Retez
    {
        private int cislo;
        private int cislo2;

        public RetezDalsi(string veta, int cislo, int cislo2) : base(veta, cislo)
        {
            Veta = veta;
            this.cislo = cislo;
            this.cislo2 = cislo2;
        }

        public override string Veta
        {
            get
            {
                return base.Veta;
            }
            set
            {
                base.Veta = value;
                while (Veta.Contains("  "))
                {
                    Veta = Veta.Replace("  ", " ");
                }
            }
        }

        public override void Zkrat()
        {
            string[] veta_array = veta.Split(' ');

            veta = string.Empty;
            for (int k = cislo; k < cislo2; k++)
            {
                veta += veta_array[k] + " ";
            }
        }
    }
}