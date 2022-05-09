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
    public partial class Form8 : Form
    {
        int variable;
        public Form8()
        {
            InitializeComponent();
        }

        void hacertodo() {

            variable = int.Parse(textBox1.Text);

            for (int i = 0; i < variable; i++)
            {
                if (i % 2 != 0)
                { 
                    listBox1.Items.Add(i);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hacertodo();
        }
    }
}
