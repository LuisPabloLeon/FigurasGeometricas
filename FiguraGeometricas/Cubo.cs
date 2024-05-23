using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometricas
{
    class Cubo:Figura
    {
        //se hace como el cuadrado pero tomando en cuenta que es una figura tridimencional
        public Cubo(float lado1)
        {
            this.Lado1 = lado1;
        }
        public override float area()
        {
            return 6 * Lado1;
        }
        public override float volumen()
        {
            return 3 * Lado1;
        }
        public override float perimetro()
        {
            throw new NotImplementedException();
        }
    }
}
