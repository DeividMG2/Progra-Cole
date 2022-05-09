using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_figuras
{
    public abstract class Figura
    {
        //métodos get y set

        public float Lado { get; set; }

        //de que manera puedo manejar la programación para que pueda registrar independiente del tipo de figura que sea, su nombre o tipo de figura?


        //métodos y funciones
        public abstract float Area();

        public abstract float Perimetro();


    }
}
