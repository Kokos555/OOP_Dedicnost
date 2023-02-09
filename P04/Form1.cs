using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace P04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Atlet idk;

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(idk.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int beh = Convert.ToInt32(textBox2.Text);
            idk.Behej(beh);
            idk.ZjistiUnavu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int spanek = Convert.ToInt32(textBox3.Text);
            idk.Spanek(spanek);
            idk.ZjistiUnavu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            idk = new Atlet("Tonda");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            idk = new Atlet("Tonda");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            idk = new Veteran("Karel",Convert.ToInt32(textBox4.Text));
        }
    }
}
