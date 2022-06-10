using System;
using System.Collections.Generic;

namespace Lección_Duran
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Figura> lista = new List<Figura>();
            cuadrado elcuadrado = new cuadrado("ejemplo cuadrado", "gris", 7);
            elcuadrado.impcuadrado();
            lista.Add(elcuadrado);

            rectangulo elrectangulo = new rectangulo("ejemplo rectangulo", "celeste", 85, 1);
            elrectangulo.imprectangulo();
            lista.Add
            (elrectangulo);
            circulo elcirculo = new circulo("ejemplo circulo:", "color piel", 37.8, 3.14);
            elcirculo.impcirculo();
            lista.Add(elcirculo);

            foreach (Figura item in lista)
            { item.Area(); }

        }
    }
}