using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Cuadrado : Poligono
    {
        
       
        public Cuadrado()
        {
            Nombre = "Cuadrado";

        }
        public double Lado
        {
            get;
            set;
        }
        public override double calcularArea()
        {
            double area;
            return area = Lado * Lado;
            
        }
        public override double calcularPerimetro()
        {
            double perimetro;
            return perimetro = 4 * Lado;
            
        }
    }
}