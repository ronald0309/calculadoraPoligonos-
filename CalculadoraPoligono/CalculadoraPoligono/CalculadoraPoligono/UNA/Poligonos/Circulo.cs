using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Circulo : Poligono
    {
        private double pi;
        private double radio;
        private double area;
        private double perimetro;
        Circulo()
        {
            pi = 3.14159265359;
            area = 0;
            perimetro = 0;
            this.radio = 0;
        }
        public override double calcularArea()
        {
            area = pi * Math.Pow(radio, 2);
            return area;
        }
        public override double calcularPerimetro()
        {
            perimetro = (2 * pi) * radio;
            return perimetro;
        }
    }
}