using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "6,251";
            textBox2.Text = "0,827";
            textBox3.Text = "25,001";


        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox4.Text +=   "Лаб.Раб №2 8К33 Костромин Д.П" + Environment.NewLine;
            double x = double.Parse(textBox1.Text);
            textBox4.Text +=  "X = " + x.ToString() + Environment.NewLine;

            double y = double.Parse(textBox2.Text);
            textBox4.Text +=  "Y = " + y.ToString() + Environment.NewLine;

            double z = double.Parse(textBox3.Text);
            textBox4.Text +=  "Z = " + z.ToString() + Environment.NewLine;
            double q = Math.Pow(Math.Abs(x), 1d/3d);
            double a = Math.Pow(y, q);
            double b = Math.Cos(y) * Math.Cos(y) * Math.Cos(y);

            double c = Math.Exp(x - y) + x / 2;

            double k = Math.Abs(x - y);
            double p = 1 + Math.Sin(z) * Math.Sin(z) / Math.Pow(x + y,0.5);
            double u = a + b * k*p / c;
            textBox4.Text += "Результат U =  " + u.ToString() + Environment.NewLine;


        }
    }
}
