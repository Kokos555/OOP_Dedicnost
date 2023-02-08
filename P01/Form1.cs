using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ryba ryba = new Ryba("Kapr");
            listBox1.Items.Add(string.Format($"{ryba.GetType().Name} {ryba.Druh} {ryba.UdelejZvuk()}"));
            Ptak ptak = new Ptak("Kos");
            listBox1.Items.Add(string.Format($"{ptak.GetType().Name} {ptak.Druh} {ptak.UdelejZvuk()}"));
            Zpevny_ptak ptakZ = new Zpevny_ptak("Skřivan");
            listBox1.Items.Add(string.Format($"{ptakZ.GetType().Name} {ptakZ.Druh} {ptakZ.UdelejZvuk()}"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zvíře[] zvirata = new Zvíře[3];
            zvirata[0] = new Ryba("Karp");
            zvirata[1] = new Ptak("Kos");
            zvirata[2] = new Zpevny_ptak("Skřivan");

            foreach (Zvíře zvire in zvirata)
            {
                listBox1.Items.Add(string.Format($"{zvire.GetType().Name} {zvire.Druh} {zvire.UdelejZvuk()}"));
            }
        }
    }
}
