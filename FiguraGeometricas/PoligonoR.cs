using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometricas
{
    class PoligonoR
    {
        //delcarar dos valores float para guardar numero de lados
        //y el apotema privados para usarse solo en esta clase
        private float apo, n;
        public float Apo //validar apotema existente o real
        {
            set
            {
                //pregunta si el apotema (es el # del centro del poligono) <0
                if (value = 0)
                {
                    apo = 0;//manda el valor a 0
                }//NO EXISTEN apotemas NEGATIVOS
                else
                {
                    apo = value;
                }//value es el valor del textbox
            }
            get//obtener el valor
            {
                return apo;//regresa o cacha el valor de la variable apotema
            }
        }
        public float N //validar el numero de lados >5
        {
            set
            {
                //pregunta si el # de lados (n) <5
                if (value < 5)
                {
                    n = 5;//manda el valor a 5
                }
                else
                {
                    n = value;
                }
            }
            get //obtener el valor
            {
                return n;
            }
        }
        //usamos el contructor de la clase poligono regular
        public PoligonoR(float lado1, float apo, float n)
        {
            Lado1 = lado1;
            Apo = apo;
            N = n;
        }
        //vamos a usar los metodos de la clase padre
        //camos a sobreescribir el comportamiento de estos
        public float area(float peri)//metodo sobrecargado que recibe el perimetro y lo utiliza
        {
            return (peri * apo) / 2;
        }
        public override float perimetro()//metodo con variable de paso que guardar el perimetro
        {
            float peri;
            peri = n * Lado1;
            return peri;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXCEPCION DE USO DEFAULT DEL SISTEMA
        }
        public override float area()//calculo de area de clase papa   
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXCEPCION DE USO DEFAULT DEL SISTEMA
        }
    }
}
