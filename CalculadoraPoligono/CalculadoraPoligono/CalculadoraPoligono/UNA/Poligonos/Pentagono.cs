using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Pentagono : Poligono
    {

        public Pentagono()
        {
            Nombre = "Pentagono";
        }
        public double Apotema
        {
            get;
            set;
        }


        public double Lado
        {
            get;
            set;
        }
        public override double calcularArea()
        {
            double area;
            double perimetro;
            perimetro = calcularPerimetro();
            return area = (perimetro * Apotema)/2;
        }

        public override double calcularPerimetro()
        {
            double perimetro;
            perimetro = 5 * Lado;
            return perimetro;
        }
    }
}