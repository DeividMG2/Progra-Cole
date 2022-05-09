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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Bachiller Aprobado")
            {
                MessageBox.Show("Aprobado");
            }
            if (comboBox1.Text == "Bachiller Reprobado")
            {
                MessageBox.Show("Selecciona si aprobaste la Prueba");
            }
               
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Prueba Aprobada")
            {
                MessageBox.Show("Aprobado");
            }
            else if (comboBox2.Text == "Prueba Reprobada")
            {
                MessageBox.Show("Reprobado");
            }
        }
    }
}
