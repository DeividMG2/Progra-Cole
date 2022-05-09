using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARREGLO
{
    public partial class Form1 : Form
    {
        string[] arreglo = new string [10];
        int alejandro = -1;
        

        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        void IntroducirNombres(){


            
            for (int i = 0; i < 10; i++)
            {
                if (arreglo[i] == null)
                {
                    arreglo[i] = pantalla.Text;
                    break;
                }
                
              
               
            }
          
                

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            IntroducirNombres();
            pantalla.Clear();
            button2.Enabled = true;
            alejandro++;
        }

        private void button2_Click(object sender, EventArgs e)



        {
            dt.Rows.Clear();
            button2.Enabled = true;
            button1.Enabled = true;

            int firulais = 1;
            dt.Rows.Add();

            for (int i = 0; i < 10; i++) {
                
                if (arreglo[i] != null)
                { }                    
                    dt.Rows[dt.Rows.Count - 1].Cells["Nombres"].Value = arreglo[i];
                   firulais++;
                }

                if (alejandro == 10)
                {
                    MessageBox.Show("YA NO PUEDES DIGITAR MAS");
                    button2.Enabled = false;
                    button1.Enabled = false;

                }

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
