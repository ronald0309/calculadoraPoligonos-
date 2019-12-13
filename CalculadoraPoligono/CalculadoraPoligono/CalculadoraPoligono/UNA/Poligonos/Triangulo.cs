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
        private double area;
        private double perimetro;
        Triangulo()
        {
            area = 0;
            perimetro = 0;
            this.lado = 0;
            this.lado =0;

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
            area = lado * altura;
            area = area / 2;
            return area;
        }
        public override double calcularPerimetro()
        {
            perimetro = 3 * lado;
            return perimetro;
        }
    }
}