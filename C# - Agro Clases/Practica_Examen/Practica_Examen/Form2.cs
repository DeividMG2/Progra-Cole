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
    public partial class Form2 : Form
    {
        double valor = 0;
        double resultado = 0;
      

        public Form2()
        {
            InitializeComponent();
        }

        void convertir() {
            
            //KB - GB
            if (comboBox1.Text == "Kilobyte" && comboBox2.Text == "Gigabyte")
            {
                textBox1.Clear();
                valor = double.Parse(textBox2.Text);
                resultado = valor / (1024*1024);
                textBox1.Text = resultado.ToString();
            }

            //KB - MB

            if (comboBox1.Text == "Kilobyte" && comboBox2.Text == "Megabyte")
            {
                textBox1.Clear();
                valor = double.Parse(textBox2.Text);
                resultado = valor / 1024;
                textBox1.Text = resultado.ToString();
            }

            //KB - TB

            if (comboBox1.Text == "Kilobyte" && comboBox2.Text == "Terabyte")
            {
                textBox1.Clear();
                valor = double.Parse(textBox2.Text);
                resultado = valor / (1024*1024*1024);
                textBox1.Text = resultado.ToString();
            }
            //KB - TB

            if (comboBox1.Text == "Kilobyte" && comboBox2.Text == "Terabyte")
            {
                textBox1.Clear();
                valor = double.Parse(textBox2.Text);
                resultado = valor / (1024 * 1024 * 1024);
                textBox1.Text = resultado.ToString();
            }

            //MB - KB

            if (comboBox1.Text == "Megabyte" && comboBox2.Text == "Kilobyte")
            {
                textBox1.Clear();
                valor = double.Parse(textBox2.Text);
                resultado = valor * (1024);
                textBox1.Text = resultado.ToString();
            }
            //MB - GB

            if (comboBox1.Text == "Megabyte" && comboBox2.Text == "Gigabyte")
            {
                textBox1.Clear();
                valor = double.Parse(textBox2.Text);
                resultado = valor / (1024);
                textBox1.Text = resultado.ToString();
            }
            //MB - TB

            if (comboBox1.Text == "Megabyte" && comboBox2.Text == "Terabyte")
            {
                textBox1.Clear();
                valor = double.Parse(textBox2.Text);
                resultado = valor / (1024*1024);
                textBox1.Text = resultado.ToString();
            }
            //GB - KB

            if (comboBox1.Text == "Gigabyte" && comboBox2.Text == "Kilobyte")
            {
                textBox1.Clear();
                valor = double.Parse(textBox2.Text);
                resultado = valor * (1024 * 1024);
                textBox1.Text = resultado.ToString();
            }

            //GB - MB

            if (comboBox1.Text == "Gigabyte" && comboBox2.Text == "Megabyte")
            {
                textBox1.Clear();
                valor = double.Parse(textBox2.Text);
                resultado = valor * (1024);
                textBox1.Text = resultado.ToString();
            }

            //GB - TB

            if (comboBox1.Text == "Gigabyte" && comboBox2.Text == "Terabyte")
            {
                textBox1.Clear();
                valor = double.Parse(textBox2.Text);
                resultado = valor / (1024);
                textBox1.Text = resultado.ToString();
            }
            //TB - KB

            if (comboBox1.Text == "Terabyte" && comboBox2.Text == "Kilobyte")
            {
                textBox1.Clear();
                valor = double.Parse(textBox2.Text);
                resultado = valor * (1024*1024*1024);
                textBox1.Text = resultado.ToString();
            }
            //TB - MB

            if (comboBox1.Text == "Terabyte" && comboBox2.Text == "Megabyte")
            {
                textBox1.Clear();
                valor = double.Parse(textBox2.Text);
                resultado = valor * (1024  * 1024);
                textBox1.Text = resultado.ToString();
            }
            //TB - GB

            if (comboBox1.Text == "Terabyte" && comboBox2.Text == "Gigabyte")
            {
                textBox1.Clear();
                valor = double.Parse(textBox2.Text);
                resultado = valor * (1024);
                textBox1.Text = resultado.ToString();
            }

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            convertir();
        }
    }
}
