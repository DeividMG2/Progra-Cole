using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoProgra_Deivid_y_Stephanie
{
    class Vehiculo
    {
        private string modelo;
        private string placa;
        private int año;
        private string marca;

        public Vehiculo(string mo, string p, int a, string ma)
        {
            modelo = mo;
            placa = p;
            año = a;
            marca = ma;

        }

        public string getModelo()
        {
            return modelo;
        }
         
        public void setModelo(string mo)
        {
            modelo = mo;
        }

        public string getPlaca()
        {
            return placa;
        }

        public void setPlaca(string p)
        {
            placa = p;
        }
        public int getAño()
        {
            return año;
        }

        public void setAño(int a)
        {
            año = a;
        }
        public string getMarca()
        {
            return marca;
        }

        public void setMarca(string ma)
        {
            marca = ma;
        }

        public void encenderVehiculo()
        {

        }

        public void apagarVehiculo()
        {

        }

        public void avanzar()
        {

        }

        public void acelerarVelocidad()
        {

        }

        public void disminuirVelocidad()
        {

        }
      
    }
}
