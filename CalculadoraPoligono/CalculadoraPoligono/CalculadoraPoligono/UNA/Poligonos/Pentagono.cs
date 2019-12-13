using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public  class Pentagono : Poligono
    {
        private double lado;
        private double area;
        private double perimetro;
        private double apotema;
        Pentagono()
        {
            
            area = 0;
            perimetro = 0;
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
           
            perimetro=calcularPerimetro();
            area = perimetro * apotema;
            area = area / 2;
            return area;
        }

        public override double calcularPerimetro()
        {
            perimetro = 5 * lado;
            return perimetro;
        }
    }
}