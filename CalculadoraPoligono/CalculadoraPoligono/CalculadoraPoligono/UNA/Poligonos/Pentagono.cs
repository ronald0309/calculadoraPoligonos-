using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public  class Pentagono : Poligono
    {
        private double lado;
        
        private double apotema;
        Pentagono()
        {
          Nombre=  "Pentagono";
        }
        public double Apotema
        {
            get
            {
                return apotema;
            }
            set
            {
                apotema = value;
            }
        }


        public double Lado
        {
            get
            {
                return lado;
            }
            set
            {
                lado = value;
            }
        }
        public override double calcularArea()
        {
            double area;
            double perimetro;
            perimetro=calcularPerimetro();
            area = perimetro * apotema;
            area = area / 2;
            return area;
        }

        public override double calcularPerimetro()
        {
            double perimetro;
            perimetro = 5 * lado;
            return perimetro;
        }
    }
}