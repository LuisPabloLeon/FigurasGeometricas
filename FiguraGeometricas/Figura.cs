using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometricas
{
    abstract class Figura //Clase Padre
    {
        /*clase va a permitir el ingreso 
         * de un lado, para poder crear una
         * nueva figura geometrica recurda
         * que una figura para existir requiere
         * minimo un lado, esta clase es un tipo
         * abstract es un molde, ella solo define
         * el comportamiento de una figura*/

        /*declaramos las variables que se 
         * va a pasar a las clases hijas nos
         * serviran para guardar en caja de 
         * memoria el valor del primer lado */

        //la variable sera privada
        private float lado1; //permite decimales

        //cramos atributos o propiedades
        //definimos el constructor
        public float Lado1
        {
            /*Metodo o modificador
             * para poner el valor (#)
             *en la caja de memoria*/
            set//poner valor
            {
                //pregunta si el valor es < 0
                if (value < 0)
                {
                    lado1 = 0; //manda el valor a 0
                }//no existen lados negativos
                else
                {
                    lado1 = value;
                    //value es el valor del textbox
                }
            }
            get //obetener el valor
            {
                return lado1;//regresa o cacha el valor de la variable lado1
            }
        }

        //definimos metodos, funciones, operaciones de la clase
        //padre que tambien van a tener hijos
        //metodos de tipo publico para que todos los usen
        //metodos abstractos van vacios ya que cada hijo
        //definira sus operaciones
        public abstract float area();
        public abstract float perimetro();
        public abstract float volumen();
    }
}
