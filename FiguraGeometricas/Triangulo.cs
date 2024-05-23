using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometricas
{
    class Triangulo:Figura //hija de clase figura
    {
        //esta clase requiere dos lados, una base y una altura para funcionar
        //creamos el lado2
        private float lado2;
        //crear un constructor para el triangulo
        public float Lado2
        {
            set
            {
                //pregunta si el lado < 0
                if (value < 0)
                {
                    lado2 = 0; //manda el valor a 0
                }//no existen lados negativos
                else
                {
                    lado2 = value;
                }
            }
            get //obetener el valor
            {
                return lado2; //regresa o cacha el valor de la variable lado2
            }
        }
        //creacion de la base de las misma forma que el lado2
        private float bac;
        //crear un constructor para el triangulo
        public float Base
        {
            set
            {
                //pregunta si el lado < 0
                if (value < 0)
                {
                    bac = 0; //manda el valor a 0
                }//no existen lados negativos
                else
                {
                    bac = value;
                }
            }
            get //obetener el valor
            {
                return bac; //regresa o cacha el valor de la variable lado3
            }
        }
        private float altura;//creacion de la altura del triangulo 
        //crear un constructor para el triangulo
        public float Altura
        {
            set
            {
                //pregunta si el lado < 0
                if (value < 0)
                {
                    altura = 0; //manda el valor a 0
                }//no existen lados negativos
                else
                {
                    altura = value;
                }
            }
            get //obetener el valor
            {
                return altura; //regresa o cacha el valor de la variable lado3
            }
        }

        public Triangulo(float lado1, float lado2, float bac, float altura)
        {//lado1, lado2 y lado 3 se va a leer de la caja de texto
         //usando el boton guardar
            this.Lado1 = lado1;//hace que unicamente el valor la
                               //cantidad del lado sea disponible
                               //para la clase rectangulo, cuando no se use rectangulo
                               //la variable sera = 0
            this.Lado2 = lado2;
            this.Base = bac;
            this.Altura = altura;
        }
        //vamos a usar los metodos de la clase padre
        //vamos a sobreescribir el comportamiento de estos
        public override float area()
        {
            return (Base * Altura) / 2;
        }
        public override float perimetro()
        {
            return Base + Lado1 + Lado2;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
        }
    }
}
