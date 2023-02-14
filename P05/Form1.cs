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
        Zamestnanec idk;

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                idk = new Zamestnanec(textBox1.Text,textBox2.Text, dateTimePicker1.Value, 100);
            }
            else
            {
                idk = new Vedouci(textBox1.Text, textBox2.Text, dateTimePicker1.Value, 100, Convert.ToInt32(textBox4.Text), textBox5.Text);
         
            }

            MessageBox.Show($"{idk.Vypis()}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idk.OdracujHodiny(Convert.ToInt32(textBox3.Text));
            MessageBox.Show($"{idk.Vypis()}");
        }
    }
}
