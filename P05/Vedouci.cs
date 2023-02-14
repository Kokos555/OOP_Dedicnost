using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05
{
    internal class Vedouci : Zamestnanec
    {
        private int priplatekZaVedeni;
        private string titul;


        public Vedouci(string jmeno, string prijmeni, DateTime datumNastupu, int hodinovaMzda, int priplatekZaVedeni, string titul) : base(jmeno, prijmeni, datumNastupu, hodinovaMzda)
        {
            this.priplatekZaVedeni = priplatekZaVedeni;
            this.titul = titul;
        }

        public override int VypoctiMzdu()
        {
            return base.VypoctiMzdu() + priplatekZaVedeni;
        }

        public override string Vypis()
        {
            return String.Format($"{titul} {base.Vypis()} Jeho mzda byla zvýšena o {priplatekZaVedeni}");
        }
    }
}
