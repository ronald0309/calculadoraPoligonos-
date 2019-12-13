using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Circulo : Poligono
    {
      
        
        public Circulo()
        {
            Nombre = "Circulo";
        }
        public double Radio
        {
            get;
            set;
        }
        public override double calcularArea()
        {
            double area;
            return area = Math.PI* Math.Pow(Radio, 2);
            
        }
        public override double calcularPerimetro()
        {
            double perimetro;
            return perimetro = (2 * Math.PI) * Radio;
            
        }
    }
}