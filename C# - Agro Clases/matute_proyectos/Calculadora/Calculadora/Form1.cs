using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double n1 = 0;
        string opcion;
        double n2 = 0;
        double res = 0;
        public Form1()
        {
            
            InitializeComponent();
          
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void pantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text+ "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            n2 = double.Parse(pantalla.Text);
            Resultado();


        }
        void Resultado()
        {
            if (opcion == "mas")
            {

                res = n1 + n2;
                pantalla.Text = res.ToString();
            }
            if (opcion == "menos")
            {

                res = n1 - n2;
                pantalla.Text = res.ToString();
            }
            if (opcion == "multiplicar")
            {

                res = n1 * n2;
                pantalla.Text = res.ToString();
            }
            if (opcion == "division")
            {

                res = n1 / n2;
                pantalla.Text = res.ToString();
            }
            if (opcion == "potencia")
            {

                res = 1;

                for (int i = 0; i < n2; i++) {

                    res = res * n1;
                   
                    
                }

                pantalla.Text = res.ToString();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            opcion = "mas";
            n1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            opcion = "menos";
            n1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            opcion = "multiplicar";
            n1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            opcion = "division";
            n1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
            n1 = 0;
            n2 = 0;
            opcion = "";
            res = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            opcion = "potencia";
            n1 = double.Parse(pantalla.Text);
            pantalla.Clear();
            Console.WriteLine("Realizando Potencia");
        }
    }
}
