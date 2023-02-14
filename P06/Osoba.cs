using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06
{
    internal class Osoba
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Hmotnost { get; }
        private int vyska;
        public int Vyska
        {
            get
            {
                return vyska;
            }
            set
            {
                vyska = value;
                if (vyska >100 && vyska < 250)
                {
                    vyska /= 100;
                }
            }
        }

        public Osoba(string jmeno, string prijmeni, int hmotnost, int vyska) 
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Hmotnost = hmotnost;
            Vyska = vyska;
        }

        public double BMI()
        {

            double BMI = Hmotnost / (vyska * vyska);
            return BMI;
        }

        public string 






    }
}
