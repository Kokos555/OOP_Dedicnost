using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04
{
    internal class Veteran : Atlet
    {
        private int vek;

        public Veteran(string jmeno, int vek) : base(jmeno)
        {
          
            this.vek = vek;
        }

        public override void Behej(int pocet_km)
        {

            if (vek <= 20)
            {
                base.Behej(pocet_km);
            }
            else
            {
                int unava_navic = vek / 20;
           
                base.Behej(pocet_km + unava_navic);
            }
        }

        public override void Spanek(int hodiny)
        {
            if (vek <= 20) {
                base.Spanek(hodiny);
            }
            else
            {
                int spanek_mene = vek / 20;
                base.Spanek(hodiny * (1 - spanek_mene * 10));
            }
        }
    }
}
