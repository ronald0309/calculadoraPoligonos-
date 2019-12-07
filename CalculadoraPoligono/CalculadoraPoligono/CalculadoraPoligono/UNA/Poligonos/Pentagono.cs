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
        Pentagono(double lado, double apotema)
        {
            this.lado = lado;
            this.apotema = apotema;
            area = 0;
            perimetro = 0;
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