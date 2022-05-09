using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejecicio_DataGrid
{
    public partial class Form1 : Form
    {


        string[] arreglo = new string[5];
        int[] cedulas = new int[5];
        string seleccionado = "";




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            Encontrar();

        }

        void llenado() {


            for (int i = 0; i < 5; i++)
            {
                if (arreglo[i] == null)
                {
                    arreglo[i] = nombre.Text;
                    break;
                }
            }
            nombre.Clear();

        }


        void llenado2()
        {

            dt.Rows.Clear();
            for (int i = 0; i < arreglo.Length; i++)
            {
                dt.Rows.Add();

                dt.Rows[dt.Rows.Count - 1].Cells["NOMBRES"].Value = arreglo[i];



            }


        }
        void Encontrar()
        {

            dt.Rows.Clear();
            for (int i = 0; i < 5; i++)
            {


                if (nombre.Text.Equals(arreglo[i]))
                {

                    for (int j = 0; j < 1; j++)
                    {

                        seleccionado = arreglo[i];
                        dt.Rows.Add();
                        dt.Rows[dt.Rows.Count - 1].Cells["NOMBRES"].Value = arreglo[i];




                    }
                }

            }



            if ((nombre.Text != arreglo[0]) && (nombre.Text != arreglo[1]) && (nombre.Text != arreglo[2]) && (nombre.Text != arreglo[3]) && (nombre.Text != arreglo[4]))
            {


                dt.Rows.Add();
                dt.Rows[dt.Rows.Count - 1].Cells["NOMBRES"].Value = "Sin Resultados";



            }


        }

        void eliminar() {

            dt.Rows.Clear();
            for (int i = 0; i < 5; i++)
            {
                if (nombre.Text.Equals(arreglo[i]))
                {
                    arreglo[i] = null;

                }


            }

            llenado2();



        }

        string imprimir_arreglo() {

            string Impri = "";

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] != null)
                {
                    Impri = Impri + "\n" + arreglo[i];
                }
            }

            return Impri;
        }

        void lleno() {


            if ((arreglo[0] != null) && (arreglo[1] != null) && (arreglo[2] != null) && (arreglo[3] != null) && (arreglo[4] != null))
            {
                MessageBox.Show("Ya digitaste el máximo de nombres");
            }
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
             MessageBox.Show(imprimir_arreglo()) ;
            
        }

        private void dt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            Encontrar();
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            llenado();
            llenado2();
            lleno();
        }
    }
}
