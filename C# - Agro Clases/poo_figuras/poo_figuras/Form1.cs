using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poo_figuras
{
    public partial class Form1 : Form
    {
        Figura f;//creando un objeto de tipo Figura
        Figura[] arreglo = new Figura[5];

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //estamos llenando el objeto cuadrado con un número fijo, en este caso es el 4

            
            f = new Cuadrado(4);
            arreglo[0] = f;

            arreglo[2] = new Cuadrado(5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Cuadrado con lado de valor: " + f.Lado);
            listBox1.Items.Add("Área del cuadrado: " + f.Area());
            listBox1.Items.Add("Perímetro del cuadrado: " + f.Perimetro());
        }
    }
}
