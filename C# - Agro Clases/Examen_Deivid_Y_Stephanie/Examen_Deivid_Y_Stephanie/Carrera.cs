using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Deivid_Y_Stephanie
{
    class Carrera
    {
        public int Cedula;
        public string Nombre;
        public string Genero;
        public float Tiempo;
        public int Posicion;        public Carrera sig;        public Carrera(int c, string n, string g, float t, int p)
        {
            Cedula = c;
            Nombre = n;
            Genero = g;
            Tiempo = t;
            Posicion = p;

        }
    }
}
