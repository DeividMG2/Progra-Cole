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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void valor(int a, int b) {

            a = 6;
            b = 4;


        }


        private void btn_valor_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;

            valor(a, b);
            MessageBox.Show("A: "+a +"\n"+"B: "+b );
        }


        void referirxd(ref int a, ref int b) {

            a = 6;
            b = 4;

        }

        private void btn_referencia_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;

            referirxd(ref a, ref b);
            MessageBox.Show("A: "+a+"\n"+ "B: " + b);
        }
    }
}
