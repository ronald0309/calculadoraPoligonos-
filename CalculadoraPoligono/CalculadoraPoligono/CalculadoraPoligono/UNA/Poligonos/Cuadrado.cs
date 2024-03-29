﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Cuadrado : Poligono
    {
        
        private double lado;
        private double area;
        private double perimetro;
        Cuadrado()
        {
            area = 0;
            perimetro = 0;
           
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
            area = lado * lado;
            return area;
        }
        public override double calcularPerimetro()
        {
            perimetro = 4 * lado;
            return perimetro;
        }
    }
}