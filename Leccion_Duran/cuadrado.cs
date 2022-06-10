using System;
using System.Collections.Generic;
using System.Text;

namespace Lección_Duran
{
    class cuadrado : Figura
    {
        public int ladosCuadra;
        public cuadrado(string nombres, string colores, int ladosCuadra) : base(nombres, colores)
        {
            this.ladosCuadra = ladosCuadra;
        }
        public override void Area()
        {
            int areacuadrados;
            areacuadrados = ladosCuadra * ladosCuadra;
            Console.WriteLine(areacuadrados);
        }
        public void impcuadrado()
        {

            Console.WriteLine(nombres);
            Console.WriteLine(colores);
        }
    }
}
