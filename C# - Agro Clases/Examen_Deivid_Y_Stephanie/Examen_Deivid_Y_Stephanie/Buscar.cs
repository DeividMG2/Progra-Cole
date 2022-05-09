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
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registrar r = new Registrar();
            r.busqueda(int.Parse(textBox1.Text));
            if(r.encontrado2)
            {
                MessageBox.Show(r.N+" se encuentra en la posicion "+ int.Parse(textBox1.Text));
            }
            else
            {
                MessageBox.Show("No se encuentra ningun corredor en la posicion: " + int.Parse(textBox1.Text));

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new Inicio();
            f.Visible = true;
            this.Hide();
        }
    }
}
