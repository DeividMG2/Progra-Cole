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
    public partial class Form5 : Form
    {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
        public Form5()
        {
            InitializeComponent();
        }
        void sumaYmultiplicacion() {
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            num3 = int.Parse(textBox3.Text);

            if (num1 < 0)
            {
                MessageBox.Show((num1 * num2 * num3).ToString());
            }
            else {
                MessageBox.Show((num1 + num2 + num3).ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
             sumaYmultiplicacion();
        }
    }
}
