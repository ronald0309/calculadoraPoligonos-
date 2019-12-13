using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Triangulo : Poligono
    {
        private double lado;
        private double altura;
        
        Triangulo()
        {
            Nombre = "Triangulo";
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
        public double Altura
        {
            get
            {
                return altura;
            }
            set
            {
                altura = value;
            }
        }

        public override double calcularArea()
        {
            double area;
            return area = (lado * altura)/2;
            
        }
        public override double calcularPerimetro()
        {
            double perimetro;
            return perimetro = 3 * lado;
            
        }
    }
}