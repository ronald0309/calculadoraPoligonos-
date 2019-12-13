using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public abstract class Poligono
    {

        protected string Nombre
        {
            get;
            set;
        }

        public abstract double calcularArea();
        public abstract double calcularPerimetro();
    }
}