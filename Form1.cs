using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        circu c = new circu();

        private void button1_Click(object sender, EventArgs e)
        {
            c.pi = 3.14159265359;
            c.raio = Convert.ToDouble(textBox1.Text);
            if (radioButton1.Checked) label2.Text = c.area;
            else if (radioButton2.Checked) label2.Text = c.perimetro;
            else if (radioButton3.Checked) label2.Text = c.diagonal;
        }
    }
}
