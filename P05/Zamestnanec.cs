using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05
{
    internal class Zamestnanec
    {
        private string jmeno;
        private string prijmeni;
        private DateTime datumNastupu;
        public int HodinovaMzda { get; }
        private int odpracHodiny;

        public Zamestnanec(string jmeno, string prijmeni, DateTime datumNastupu, int hodinovaMzda)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.datumNastupu = datumNastupu;
            HodinovaMzda = hodinovaMzda;
            odpracHodiny = 0;
        }

        public double PocetDni()
        {
            double dny;
            DateTime ted = DateTime.Now;
            TimeSpan odprac_dny = ted - datumNastupu;
            dny = odprac_dny.Days;
            return dny;
        }

        public void OdracujHodiny(int hodiny_navíc)
        {
            odpracHodiny += hodiny_navíc;
        }

        public virtual int VypoctiMzdu()
        {
            return odpracHodiny * HodinovaMzda;
        }

        public virtual string Vypis()
        {
            return string.Format($"{jmeno} {prijmeni} je v práci {PocetDni()} dní/ů, má odpracováno {odpracHodiny} hodin, jeho hodinová mzda je {HodinovaMzda} a celkem si vydělal {VypoctiMzdu()} Kč.");
        }
    }
}
