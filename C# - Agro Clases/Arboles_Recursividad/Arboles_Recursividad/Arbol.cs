using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles_Recursividad
{
    public class Arbol
    {
        public int valor;
        public Arbol der;
        public Arbol izq;

        //constructor
        public Arbol(int n)
        {
            valor = n;
        }
    }
}
