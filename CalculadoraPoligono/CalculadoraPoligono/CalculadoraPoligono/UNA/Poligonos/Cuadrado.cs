using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Cuadrado : Poligono
    {
        
        private double lado;
        Cuadrado()
        {
            Nombre = "Pentagono";

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
            return area = lado * lado;
            
        }
        public override double calcularPerimetro()
        {
            double perimetro;
            return perimetro = 4 * lado;
            
        }
    }
}