using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaUno
{
    public partial class Form1 : Form
    {
        int variable;

        int funcion(int v1, int v2) {
            int suma;
            suma = v1 + v2;

            return suma;
        }


        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add(2001);
            comboBox1.Items.Add(2002);
            comboBox1.Items.Add(2003);
            comboBox1.Items.Add(2004);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Te dije que no me presionaras JO-DEEEEEER");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ya has perdido, ya no vale.");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

           int suma = funcion(5,5);
            MessageBox.Show("" + suma);

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
