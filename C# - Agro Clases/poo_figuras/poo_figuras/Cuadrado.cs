using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_figuras
{
    public class Cuadrado : Figura //CLASE CUADRADO HEREDA DE FIGURA
    {



        //Constructor de la clase Cuadrado
        public Cuadrado(float l)
        {
            this.Lado = l;//Como tenemos una herencia de la clase Figura, podemos utilizar Lado sin haberla declarado     
        }


        //funcion que calcula el area del cuadrado, esta funcion sobreescribe el método padre (Area) de la clase Figura
        //de manera que podemos hacer nuestra función Area de la manera más específica de acuerdo al tipo de figura geométrica Cuadrado
        public override float Area()
        {
            return (this.Lado * this.Lado);
        }


        //funcion para devolver el perimetro del cuadrado
        public override float Perimetro()
        {
            return (this.Lado * 4);
        }
    }
}
