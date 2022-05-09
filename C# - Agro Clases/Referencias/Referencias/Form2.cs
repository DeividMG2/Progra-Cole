using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Referencias
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
        }
       

        void Intercambio(ref int x, ref int y) {
            
            int u = y;
            y = x;
            x = u;
           
          

        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);

            Intercambio(ref x, ref y);

            textBox1.Text = x.ToString();
            textBox2.Text = y.ToString();

        }
    }
}
