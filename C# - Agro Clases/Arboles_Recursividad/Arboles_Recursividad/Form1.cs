using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles_Recursividad
{
    public partial class Form1 : Form
    {
        public Arbol raiz;
        int[] array = { 1, 2, 3, 4, 5 };
        Boolean found = false; 
        public Form1()
        {
            InitializeComponent();
        }

        /*
A modo investigación y programación a la vez, utilizando la herramienta Visual Studio
con lenguaje de programación C#, implementar los procedimientos de recorrido e impresión
de árboles binarios:

Orden
PreOrden
PostOrden
Utilice como base, el proyecto facilitado por el profesor, el mismo ya posee la clase
del Árbol programada, como también, el método de inserción ordenada en el árbol. 

Para la impresión de los recorridos utilice un listBox, además, crear un botón para llamar
a cada procedimiento de recorrido. 

Importante, proceda a documentar las líneas de cada procedimiento implementado.

En el entregable de este proyecto, debe subir el proyecto en cualquiera de los formatos
.zip, .rar, .7zip
        */

        private void button1_Click(object sender, EventArgs e)
        {
            contador(1);
        }

        //CONTAR DESDE CERO HASTA UN NUMERO 10
        void contador(int iNumero)
        {
            if (iNumero < 10)
            {
                listBox1.Items.Add(iNumero);
                contador(iNumero + 1);
            }
        }

        //CALCULAR FACTORIAL DE UN NUMERO
        long Factorial(long x)
        {
          
                if (x == 1)
                {
                    return 1;
                }
                else
                {
                    return x * Factorial(x - 1);
                }
            
         
               
          
           

        }
 
        //RECORRER ARREGLO DE MANERA RECURSIVA
        void recorrerArreglo(int[] array, int indice)
        {
            if (indice != array.Length)
            {                
                listBox1.Items.Add(array[indice]); //Mostramos el valor en ese indice                
                recorrerArreglo(array, indice + 1); //Llamamos recursivamente a la función
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                listBox1.Items.Add(Factorial(long.Parse(textBox1.Text)));
            
                
               
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            recorrerArreglo(array, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Insertar(int.Parse(textBox2.Text));
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            textBox2.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //insertar de manera ordenada en arbol binario
        public void Insertar(int info)
        {
            Arbol nuevo;
            
            nuevo = new Arbol(info);
            nuevo.valor = info;
            nuevo.izq = null;
            nuevo.der = null;
            if (raiz == null)
                raiz = nuevo;
           
            else
            {
                Arbol anterior = null, reco;
                reco = raiz;
                while (reco != null)
                {
                  
                    anterior = reco;
                    if (info < reco.valor)
                        reco = reco.izq;
                    else
                    {
                        reco = reco.der;
                    }


                    }
                if (info < anterior.valor)
                {
                    anterior.izq = nuevo;

                }
                else
                {
                    anterior.der = nuevo;
                    
                }
              
            }
            
        }

        void Orden(Arbol r)
        {
          
            if (r != null)
            {
                Orden(r.izq);
                listBox2.Items.Add("Valor: " + r.valor);
                Orden(r.der);
            }
            

        }

        void busqueda(Arbol r, int v)
        {

            if (r != null)
            {
                if (r.valor == v)
                {
                    found = true;
                }
                busqueda(r.izq, int.Parse(textBox3.Text));
                busqueda(r.der, int.Parse(textBox3.Text));
                
            }

        }
        void preorden(Arbol r)
        {

            if (r != null)
            {
                listBox2.Items.Add("Valor: " + r.valor);
                preorden(r.izq);
                preorden(r.der);
                
            }


        }

        void postorden(Arbol r)
        {
            if(r != null)
            {
                postorden(r.izq);
                postorden(r.der);
                listBox2.Items.Add("Valor: " + r.valor);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Orden(raiz);
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            preorden(raiz);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            postorden(raiz);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            { 
            busqueda(raiz, int.Parse(textBox3.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (found)
            {
                MessageBox.Show("El valor si se encontró.");
            }
            else
            {
                MessageBox.Show("El valor no se encontró.");

            }
            found = false;
            textBox3.Clear();
        }
    }
}
