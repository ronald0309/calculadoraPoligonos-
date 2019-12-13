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
        
        public Rectangulo()
        {
            Nombre = "Rectangulo";
        }
        public double Ancho
        {
            get
            {
                return ancho;
            }
            set
            {
                ancho = value;
            }
        }
        public double Largo
        {
            get
            {
                return largo;
            }
            set
            {
                largo = value;
            }
        }
        public override double calcularArea()
        {
            double area;
            return area = largo * ancho;
            
        }
        public override double calcularPerimetro()
        {
            double perimetro;
            
            return perimetro = (2 * ancho) + (2 * largo);
            
        }
    }
}