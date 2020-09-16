using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Exec_01
{
    class Retangulo
    {
        public double v_dLargura;
        public double v_dAltura;

        public void Area(double Area)
        {
            Area = v_dAltura * v_dLargura;
        }

        public void Perimetro(double Per)
        {
            Per = 2 * (v_dAltura + v_dLargura);
        }

        public void Diagonal(double Dia)
        {
            Dia = Math.Sqrt(((v_dAltura * v_dAltura) + (v_dLargura * v_dLargura)));
        }

    }
}
