using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Rectangulo : Poligono
    {
        private double ancho;
        private double largo;
        private double area;
        private double perimetro;
        Rectangulo()
        {
            area = 0;
            perimetro = 0;
            this.ancho = ancho;
            this.largo = largo;
        }
        public override double calcularArea()
        {
            area = largo * ancho;
            return area;
        }
        public override double calcularPerimetro()
        {
            perimetro = (2 * ancho) + (2 * largo);
            return perimetro;
        }
    }
}