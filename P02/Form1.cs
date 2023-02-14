using P02;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string veta = textBox1.Text;
            int cislo = Convert.ToInt32(textBox2.Text);

            Retez test = new Retez(veta, cislo);
            MessageBox.Show(string.Format($"{test.Vypis()}"));
            MessageBox.Show(string.Format($"{test.Zkrat()}"));

            Retez test2 = new Retez(veta,cislo);
            MessageBox.Show(string.Format($"{test2.Vypis()}"));
            MessageBox.Show(string.Format($"{test2.Zkrat()}"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string veta = textBox1.Text;
            int cislo = Convert.ToInt32(textBox2.Text);
            int cisloOd = Convert.ToInt32(textBox3.Text);

            RetezDalsi vstup = new RetezDalsi(veta, cisloOd, cislo);
            MessageBox.Show(vstup.Veta);
            MessageBox.Show(vstup.Zkrat());

        }
    }
}
