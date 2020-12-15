﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Formas_Geometricas
{
    class Circulo : Forma
    {

        public double Raio { get; set; }

        public Circulo(double raio, Cor cor): base(cor)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
