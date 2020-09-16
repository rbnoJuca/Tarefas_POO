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
        public string info;

        public void areaRetangulo(string areaR)
        {
            double Area = (v_dAltura * v_dLargura);
            areaR = Area.ToString();
        }

        public void perimetroRetangulo(double Per)
        {
            Per = 2 * (v_dAltura + v_dLargura);
            Per.ToString("f2", CultureInfo.InvariantCulture);
        }

        public void diagonalRetangulo(double Diagonal)
        {
            Diagonal = Math.Sqrt(((v_dAltura * v_dAltura) + (v_dLargura * v_dLargura)));
            Diagonal.ToString("f2", CultureInfo.InvariantCulture);
        }

        //public override string ToString()
        //{
        //    return info 
        //        + "Area: " 
        //        + Area.ToString() 
        //        +  ;
        //}

    }
}
