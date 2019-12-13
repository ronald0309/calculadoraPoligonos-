using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Rectangulo : Poligono
    {
       
        
        public Rectangulo()
        {
            Nombre = "Rectangulo";
        }
        public double Ancho
        {
            get;
            set;
        }
        public double Largo
        {
            get;
            set;
        }
        public override double calcularArea()
        {
            double area;
            return area = Largo * Ancho;
            
        }
        public override double calcularPerimetro()
        {
            double perimetro;
            
            return perimetro = (2 * Ancho) + (2 * Largo);
            
        }
    }
}