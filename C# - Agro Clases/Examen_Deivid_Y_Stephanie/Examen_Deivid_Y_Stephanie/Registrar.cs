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

    public partial class Registrar : Form
    {

        public bool encontrado;
        static Carrera raiz;
        public bool encontrado2;
        public string N;
        public static bool ActivarBotones = false;
        int n = int.MaxValue;

        public Registrar()
        {

            InitializeComponent();
        }

        void insertar(Carrera nuevoNodo)
        {


            if (raiz == null)
            {
                raiz = nuevoNodo;
            }
            else
            {
                Carrera aux = raiz;
                while (aux.sig != null)
                {

                    aux = aux.sig;

                }

                aux.sig = nuevoNodo;

            }

            ActivarBotones = true;
         

        }



       
        public void eliminando(int c)
        {
            Carrera aux = raiz;
            Carrera ant = raiz;
            encontrado = false;

            while (aux != null)
            {
                if (raiz.Cedula == c)
                {
                    raiz = raiz.sig;
                    encontrado = true;
                    break;
                }
                else if (aux.Cedula == c)
                {
                    encontrado = true;
                    ant.sig = aux.sig;
                    break;
                }
                ant = aux;
                aux = aux.sig;


            }

        }

        public float promedio()
        {
            float PromedioRecorrido = 0;
            int contador = 0;
            Carrera aux = raiz;
            while (aux != null)
            {
                PromedioRecorrido = PromedioRecorrido + aux.Tiempo;
                contador++;
                aux = aux.sig;
            }
            PromedioRecorrido = PromedioRecorrido / contador;


            return PromedioRecorrido;
        }
        public string MejorTiempo()
        {
            float MayorT = float.MaxValue;
            string nombreMejor = null;
            Carrera aux = raiz;
            while (aux != null)
            {
                if (aux.Tiempo < MayorT)
                {
                    MayorT = aux.Tiempo;
                    nombreMejor = aux.Nombre;
                }

                aux = aux.sig;
            }



            return nombreMejor;
        }

        public string PeorTiempo()
        {
            float PeorT = float.MinValue;
            string nombrePeor = null;
            Carrera aux = raiz;
            while (aux != null)
            {
                if (aux.Tiempo > PeorT)
                {
                    PeorT = aux.Tiempo;
                    nombrePeor = aux.Nombre;
                }

                aux = aux.sig;
            }



            return nombrePeor;
        }

        public void busqueda(int p)
        {
            Carrera aux = raiz;
            encontrado2 = false;
            while (aux != null)
            {
                if (aux.Posicion == p)
                {
                    encontrado2 = true;
                    N = aux.Nombre;
                    break;
                }
                aux = aux.sig;
            }
        }
        void imprimirH()

        {
            listBox1.Items.Clear();
            Carrera aux = raiz;
            int contador = 0;
            while (aux != null)
            {
                    if ((aux.Genero == "Hombre")|| (aux.Genero == "hombre")|| (aux.Genero == "HOMBRE"))
                    {
                        contador++;
                        listBox1.Items.Add("Nombre: " + aux.Nombre + " - Posicion: " + aux.Posicion);
                        
                    }
                aux = aux.sig;
            }
            
                if (contador == 1)
                {
                    listBox1.Items.Add("Participó un hombre en la carrera");

                }
            else if (contador == 0)
            {
                listBox1.Items.Add("No participaron hombres en la carrera");
            }
            else
                {
                    listBox1.Items.Add("Participaron " + (contador ) + " hombres en la carrera");

                }
            
            
        }

        void imprimirM()

        {
            listBox1.Items.Clear();
            Carrera aux = raiz;
            aux = raiz;
            int contador = 0;
            while (aux != null)
            {
                if ((aux.Genero == "Mujer")|| (aux.Genero == "MUJER")|| (aux.Genero == "mujer"))
                {
                    contador++;
                    listBox1.Items.Add("Nombre: " + aux.Nombre + " - Posicion: " + aux.Posicion);
                }
                aux = aux.sig;
            }


            if (contador == 1)
            {
                listBox1.Items.Add("Participó una mujer en la carrera");

            }
            else if (contador == 0)
            {
                listBox1.Items.Add("No participaron mujeres en la carrera");
            }
            else
            {
                listBox1.Items.Add("Participaron " + (contador) + " mujeres en la carrera");

            }
        }


    
         

        private void button1_Click(object sender, EventArgs e)
        {
            Carrera n = new Carrera(int.Parse(textBox2.Text), textBox1.Text, textBox3.Text, float.Parse(textBox5.Text), int.Parse(textBox4.Text));
            insertar(n);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            imprimirH();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            imprimirM();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Registrar r = new Registrar();
            Form i = new Inicio();
            i.Visible = true;
            this.Hide();
        
    }

        private void Registrar_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
