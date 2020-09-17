using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Transactions;

namespace Exec_01
{
    class Retangulo
    {
        public double v_dLargura;
        public double v_dAltura;

        public double areaRetangulo()
        {
            double Area = (v_dAltura * v_dLargura);
            return Area;
            
        }

        public double perimetroRetangulo()
        {
            double Per = 2 * (v_dAltura + v_dLargura);
            return Per;
        }

        public double diagonalRetangulo()
        {
            double Diagonal = Math.Sqrt(((v_dAltura * v_dAltura) + (v_dLargura * v_dLargura)));
            return Diagonal;
        }

    }
}
