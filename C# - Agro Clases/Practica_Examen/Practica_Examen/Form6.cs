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
    public partial class Form6 : Form
    {
        int valor = 0;

        public Form6()
        {
            InitializeComponent();
        }

         void verificar() {
            valor = int.Parse(textBox1.Text);

            if (valor == 0)
            {
                MessageBox.Show("El numero no es par ni impar");
            }
            else if (valor % 2 == 0)
            {
                MessageBox.Show("El numero es par");
            }
            else {
                MessageBox.Show("El numero es impar");
            }
            
        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            verificar();
        }
    }
}
