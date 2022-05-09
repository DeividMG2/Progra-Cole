using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Examen
{
    public partial class Form3 : Form
    {
        double res = 0;
        double v1 = 0;
        double v2 = 0;

        public Form3()
        {
            InitializeComponent();
         
        }
        

        void resolver() {

            if (radioButton1.Checked) {
                suma();
            } else if (radioButton2.Checked) {
                resta();
            }
            else if (radioButton3.Checked)
            {
                multi();
            }
            else if (radioButton4.Checked)
            {
                divi();
            }

        }
        void suma() {
            res = v1 + v2;
            textBox3.Text = res.ToString();
        }
        void resta() {
            res = v1 - v2;
            textBox3.Text = res.ToString();
        }
        void divi() {
           
            res = v1 / v2;
            textBox3.Text = res.ToString();
        }
        void multi() {
            res = v1 * v2;
            textBox3.Text = res.ToString();
        }

        void limpieza() {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            textBox3.Clear();



        }


        private void button1_Click(object sender, EventArgs e)
        {
          v1 = double.Parse(textBox1.Text);
          v2 = double.Parse(textBox2.Text);
           
            resolver();
            limpieza();
        }
    }
}
