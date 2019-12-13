using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Circulo : Poligono
    {
        
        private double radio;
        
        public Circulo()
        {
            Nombre = "Circulo";
        }
        public double Radio
        {
            get
            {
                return radio;
            }
            set
            {
                radio = value;
            }
        }
        public override double calcularArea()
        {
            double area;
            return area = Math.PI* Math.Pow(radio, 2);
            
        }
        public override double calcularPerimetro()
        {
            double perimetro;
            return perimetro = (2 * Math.PI) * radio;
            
        }
    }
}