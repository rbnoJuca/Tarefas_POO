using System;
using System.Collections.Generic;
using System.Text;


namespace Formas_Geometricas
{
    abstract class Forma
    {

        public Cor cor { get; set; }
        public Forma(Cor color)
        {
            cor = color;
        }

        public abstract double Area();

    }
}
