using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PretezovaniMetod
{
    public partial class Form1 : Form
    {
        bool jednicka = false;
        bool dvojka = false;
        bool trojka = false;
        bool ctyrka = false;
        public double Obsah(int a)
        {
            int obs = a * a;
            return obs;
        }
        public double Obsah(int d, int e)
        {
            int obs = d * e;
            return obs;
        }
        public double Objem(int f)
        {
            int obj = f * f * f;
            return obj;
        }
        public double Objem(int g, int h, int j)
        {
            int obj = g * h * j;
            return obj;
        }

        public Form1()
        {
           
            InitializeComponent();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
           
            

        }

        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dvojka = false; trojka = false; ctyrka = false;
            textBox1.Enabled = true;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            label4.Text = "Obsah Čtverce:";
            jednicka = true;
        }

        public void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            jednicka = false; trojka = false; ctyrka = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = false;
            label4.Text = "Obsah Obdélníku:";
            dvojka = true;
        }

        public void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            jednicka = false; dvojka = false; ctyrka = false;
            textBox1.Enabled = true;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            label4.Text = "Objem Krychle:";
            trojka = true;
        }

        public void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            jednicka = false; dvojka = false; trojka = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            label4.Text = "Objem Kvádru:";
            ctyrka = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                label5.Text = "";
                if (jednicka)
                {
                try
                    {
                        int a = int.Parse(textBox1.Text);
                        label5.Text = Obsah(a).ToString() + " mm2";
                    }
                    catch { };
                }
                if (dvojka)
                {
                try
                    {
                        int a = int.Parse(textBox1.Text);
                        int b = int.Parse(textBox2.Text);
                        label5.Text = Obsah(a, b).ToString() + " mm2";
                    }
                    catch { };
                }
                if (trojka)
                {
                try
                    {
                        int a = int.Parse(textBox1.Text);
                        label5.Text = Objem(a).ToString() + " mm3";
                    }
                    catch { };
                }
                if (ctyrka)
                {
                try
                    {
                        int a = int.Parse(textBox1.Text);
                        int b = int.Parse(textBox2.Text);
                        int c = int.Parse(textBox3.Text);
                        label5.Text = Objem(a, b, c).ToString() + " mm3";
                    }
                    catch { };
                }
        }
    }
}
