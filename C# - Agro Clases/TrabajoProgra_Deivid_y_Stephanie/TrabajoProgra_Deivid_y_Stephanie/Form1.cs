using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoProgra_Deivid_y_Stephanie
{
    
    public partial class Form1 : Form
    {
        bool v_encendido = false;
        bool v_creado = false;
        bool v_detenido = true;
        Vehiculo v;
        int velocidad = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void crearVehiculo()
        {
            listBox1.Items.Add("Marca: "+v.getMarca()+ " - - - - - - - - - - - - Modelo: " + v.getModelo()+ " - - - - - - - - - - - - Año: " + v.getAño() + " - - - - - - - - - - - - Placa: " + v.getPlaca());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                v = new Vehiculo(textBox3.Text, textBox4.Text, int.Parse(textBox1.Text), textBox2.Text);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                MessageBox.Show("Tu Vehículo ha sido creado exitosamente");
                v_creado = true;
            }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.Message);
            }
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                crearVehiculo();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (v_creado)
                {
                    if (v_encendido == false)
                    {
                        v_encendido = true;
                        listBox1.Items.Add("¡Has encendido tu " + v.getMarca() + "!");
                    }
                    else
                    {
                        listBox1.Items.Add("¡El vehículo ya está encendido!");
                    }
                }
                else
                {
                    MessageBox.Show("No hay ningún vehículo creado.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (v_creado)
                {
                    if (v_encendido)
                    {
                        v_encendido = false;
                        listBox1.Items.Add("¡Has apagado tu " + v.getMarca() + "!");
                    }
                    else
                    {
                        listBox1.Items.Add("¡El vehículo ya está apagado!");
                    }
                }
                else
                {
                    MessageBox.Show("No hay ningún vehículo creado.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                if (v_creado)
                {
                    if (v_encendido)
                    {
                        if ((velocidad + int.Parse(textBox5.Text) < 200)&& (velocidad + int.Parse(textBox5.Text) >= 0))
                        {
                            velocidad += int.Parse(textBox5.Text);
                            v_detenido = true;
                            listBox1.Items.Add("Tu " + v.getMarca() + " está avanzado a " + velocidad + " km/h");
                        }
                        else
                        {
                            MessageBox.Show("Tu vehículo no puede avanzar tanto, intenta bajar la velocidad.");
                            textBox5.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El vehículo está apagado.");
                    }
                }
                else
                {
                    MessageBox.Show("No hay ningún vehículo creado.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (v_creado)
                {
                    if (v_encendido)
                    {
                        if((velocidad+10)<200)
                        {
                            velocidad += 10;
                            v_detenido = true;
                            listBox1.Items.Add("Tu " + v.getMarca() + " aceleró 10 km/h");
                            listBox1.Items.Add("Tu " + v.getMarca() + " está avanzando a " + (velocidad) + " km/h");
                        }
                        else
                        {
                            MessageBox.Show("Ya no puedes acelerar más.");
                        }
                       

                    }
                    else
                    {
                        MessageBox.Show("El vehículo está apagado.");
                    }

                }
                else
                {
                    MessageBox.Show("No hay ningún vehículo creado.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (v_creado)
                {
                    if (v_encendido)
                    {
                        if ((velocidad > 0) && (velocidad - 10 > 0))
                        {
                            velocidad -= 10;
                            listBox1.Items.Add("Tu " + v.getMarca() + " disminuyó 10 km/h");
                            listBox1.Items.Add("Tu " + v.getMarca() + " está avanzando a " + (velocidad) + " km/h");
                        }
                        else if  ((velocidad - 10 <= 0) && (v_detenido == true))
                        {
                            listBox1.Items.Add("El vehículo está detenido");
                            v_detenido = false;
                        }
                        else
                        {
                            MessageBox.Show("No puedes disminuir más, el vehiculo está detenido");
                        }

                    }else
                    {
                        MessageBox.Show("El vehículo está apagado.");
                    }

                }
                else
                {
                    MessageBox.Show("No hay ningún vehículo creado.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
