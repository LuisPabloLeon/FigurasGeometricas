using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometricas
{
    class Esfera:Figura
    {
        public Esfera(float radio)
        {
            this.Lado1 = radio;
        }
        public override float area()
        {
            return 3.1416F * (2 * Lado1);
        }
        public override float perimetro()
        {
            return 2 * 3.1416F * Lado1;
        }
        public override float volumen()
        {
            return 4 / 3 * 3.1416F * (3 * Lado1);
        }
    }
}
