using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometricas
{
    class Cuadrado:Figura
    {
        //el cuadrado solo usa un lado ya que todos los lados son iguales
        public Cuadrado(float lado1)
        {//lado1 se va a leer de la caja de texto
         //usando el boton guardar
            this.Lado1 = lado1;//hace que unicamente el valor la
                               //cantidad del lado sea disponible
                               //para la clase rectangulo, cuando no se use rectangulo
                               //la variable sera = 0
        }
        //vamos a usar los metodos de la clase padre
        //vamos a sobreescribir el comportamiento de estos
        public override float area()
        {
            return Lado1 * Lado1;
        }
        public override float perimetro()
        {
            return Lado1 * 4;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
            //esto es una exepcion de uso default del sistema
        }

    }
}
