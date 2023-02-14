using P02;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02
{
    internal class RetezDalsi : Retez
    {
        private int cisloOd;

        public RetezDalsi(string veta, int cisloOd, int cislo) : base(veta, cislo)
        {
            this.cisloOd = cisloOd;
        }


        public override int PocetSlov()
        {
            string[] pole = Veta.Split(' ');
            int pocet = 0;
            foreach (string p in pole)
            {
                if (p != "")
                {
                    pocet++;
                }
            }
            return pocet;
        }
        public override string Zkrat()
        {
            Veta = base.Zkrat();
            string[] slova = Veta.Split(' ');
            slova = slova.Skip(cisloOd).ToArray();

            Veta = string.Join(" ", slova);

            return Veta;
        }
    }
}