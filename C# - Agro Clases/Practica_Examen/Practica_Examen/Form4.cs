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
    public partial class Form4 : Form
    {
        int mayor = 0, menor = int.MaxValue, medio = 0;
        int[] arreglo = new int[3];
        Boolean pepe = true;
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mayor = int.MinValue;
            menor = int.MaxValue;
            medio = 0;
            for (int i = 0; i < 3; i++)
            {
                arreglo[i] = 0;
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        void buscar() {
     
            int v1 = int.Parse(textBox1.Text);
            int v2 = int.Parse(textBox3.Text);
            int v3 = int.Parse(textBox2.Text);

           
           
                arreglo[0] = v1;
                arreglo[1] = v2;
                arreglo[2] = v3;
            
            for (int i = 0; i < 3; i++)
            {
                if (v1 == v2 && v1 == v3)
                {
                    MessageBox.Show("Los numeros son iguales");
                    pepe = false;
                    break;
                }
                if (arreglo[i] > mayor)
                {
                    mayor = arreglo[i];
                }
                if (arreglo[i] < menor)
                {
                    menor = arreglo[i];
                }
               
            }
            for (int i = 0; i < 3; i++)
            {
                if (arreglo[i] > menor && arreglo[i] < mayor)
                {
                    medio = arreglo[i];
                }
            }
            if (pepe)
            {
                textBox4.Text = "Numero Mayor: " + mayor + "                   Numero Menor: " + menor + "               Numero Intermedio: " + medio;

            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox4.Clear();
            buscar();
            
        }
    }
}
