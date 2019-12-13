using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Triangulo : Poligono
    {
        
        public Triangulo()
        {
            Nombre = "Triangulo";
        }
        public double Lado
        {
            get;
            set;
        }
        public double Lado2
        {
            get;
            set;
        }
        public double Lado3
        {
            get;
            set;
        }
        public double Altura
        {
            get;
            set;
        }
        public double Base
        {
            get;
            set;
        }

        public override double calcularArea()
        {
            double area;
            return area = (Base * Altura)/2;
            
        }
        public override double calcularPerimetro()
        {
            double perimetro;
            return perimetro = Lado+Lado2+Lado3;
            
        }
    }
}