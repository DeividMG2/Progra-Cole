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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        void seleccion() {

            if (comboBox1.Text == "Cuadrado")
            {
                panel2.Visible = true;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                

            }

            else if (comboBox1.Text == "Rectangulo")
            {
                panel3.Visible = true;
               panel2.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
            }
            else if (comboBox1.Text == "Triangulo")
            {
                panel4.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
                panel5.Visible = false;
            }
            else if (comboBox1.Text == "Circulo")
            {
                panel5.Visible = true;
                panel2.Visible = false;
                panel4.Visible = false;
                panel3.Visible = false;
            }

        }
        string cuadrado(int  l1, int  l2, int area, int perimetro) {

            area = l1 * l2;
            perimetro = (l1 * 2) + (l2*2);


            return "Area: " + area+ "\n"+ "Perimetro: "+perimetro;
        }
        string rectangulo(int l1, int l2, int area, int perimetro) {

            area = l1 * l2;
            perimetro = (l1 * 2) + (l2 * 2);


            return "Area: " + area + "\n" + "Perimetro: " + perimetro;
        }
        string circulo(int radio, double area, double perimetro) {

            area = 3.1416 * (radio*radio);
            perimetro = (2 * 3.1416) * radio;

            return "Area: " + area + "\n" + "Perimetro: " + perimetro;
        }
        string triangulo(int l1, int l2, int area, int perimetro) {
            area = (l1 * l2)/2;
            perimetro = l1 * 3;
            return "Area: " + area + "\n" + "Perimetro: " + perimetro;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int l1 = int.Parse(ladoUno.Text);
            int l2 = int.Parse(ladoDos.Text);
            int area = 0, perimetro = 0;

            MessageBox.Show(cuadrado(l1, l2, area, perimetro));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int l1 = int.Parse(textBox4.Text);
            int l2 = int.Parse(textBox3.Text);
            int area = 0, perimetro = 0;
            MessageBox.Show(rectangulo(l1, l2, area, perimetro));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int l1 = int.Parse(textBox6.Text);
            int l2 = int.Parse(textBox5.Text);
            int area = 0, perimetro = 0;
            MessageBox.Show(triangulo(l1, l2, area, perimetro));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int radio = int.Parse(textBox8.Text);
            double area = 0, perimetro = 0;
            MessageBox.Show(circulo(radio, area, perimetro));
        }
    }
}
