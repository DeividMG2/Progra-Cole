using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Deivid_Y_Stephanie
{
    public partial class Inicio : Form
    {
        

        public Inicio()
        {
          
            InitializeComponent();
            if (Registrar.ActivarBotones)
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Registrar();
            f.Visible = true;
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form el = new eliminar();
            el.Visible = true;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registrar r = new Registrar();
            MessageBox.Show("El promedio recorrido entre todos los corredores es: "+r.promedio());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Registrar r = new Registrar();
            MessageBox.Show("El mejor tiempo lo hizo: " + r.MejorTiempo());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Registrar r = new Registrar();
            MessageBox.Show("El peor tiempo lo hizo: " + r.PeorTiempo());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form b = new Buscar();
            b.Visible = true;
            this.Hide();
        }
    }
}
