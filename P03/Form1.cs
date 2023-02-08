using P03;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NakladniAuto test;
        private void button1_Click(object sender, EventArgs e)
        {
            //string spz = textBox1.Text;
            //int nosnost = Convert.ToInt32(textBox2.Text);
            MessageBox.Show(test.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            test.VylozNaklad(Convert.ToInt32(textBox3.Text));
            MessageBox.Show(test.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test.NalozNaklad(Convert.ToInt32(textBox3.Text));
            MessageBox.Show(test.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            test = new NakladniAuto("3J7 1923", 100);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            test = new NakladniAuto("3J7 1923", 100);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            test = new Tahac("3J7 1923", 100, 150);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            test = new NakladniAuto("3J7 1923", 100);
        }
    }
}
