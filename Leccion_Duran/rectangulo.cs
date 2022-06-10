using System;
using System.Collections.Generic;
using System.Text;

namespace Lección_Duran
{
    class rectangulo : Figura
    {
        public int alturas, bases;
        public rectangulo(string nombres, string colores, int alturas, int bases) : base(nombres, colores)
        {
            this.alturas = alturas;
            this.bases = bases;
        }
        public void imprectangulo()
        {
            Console.WriteLine(nombres);
            Console.WriteLine(colores);
        }
        public override void Area()
        {
            int arearectangulos;
            arearectangulos = bases * alturas;
            Console.WriteLine(arearectangulos);
        }
    }
}