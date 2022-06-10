using System;
using System.Collections.Generic;
using System.Text;

namespace Lección_Duran
{
    abstract class Figura
    {
        public abstract void Area();
        public string nombres, colores;
        public Figura(string nombres, string colores)
        { this.nombres = nombres; this.colores = colores; }
    }
}