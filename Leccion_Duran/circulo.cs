using System;
using System.Collections.Generic;
using System.Text;

namespace Lección_Duran
{
    class circulo : Figura
    {
        public double picirculo, radiocirculos;
        public circulo(string nombres, string colores, double RadioCirculo, double NumeroPI) : base(nombres, colores)
        {
            this.radiocirculos = RadioCirculo;
            this.picirculo = NumeroPI;
        }
        public void impcirculo()
        {

            Console.WriteLine(nombres);
            Console.WriteLine(colores);
        }
        public override void Area()
        {
            double areacirculos;
            radiocirculos = Math.Pow(radiocirculos, 2);
            areacirculos = radiocirculos * picirculo;
            Console.WriteLine(areacirculos);
        }
    }
}
