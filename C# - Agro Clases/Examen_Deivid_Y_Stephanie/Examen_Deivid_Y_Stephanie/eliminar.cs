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
    public partial class eliminar : Form
    {
        
        public eliminar()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)

        {
            Registrar r = new Registrar();
            r.eliminando(int.Parse(textBox1.Text));
            if (r.encontrado)
            {
                MessageBox.Show("El corredor o corredora ha sido eliminado");
            }
            else
            {
                MessageBox.Show("El corredor o corredora no ha sido encontrado");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form r = new Registrar();
            r.Visible = true;
            this.Hide();
        }
    }
}
