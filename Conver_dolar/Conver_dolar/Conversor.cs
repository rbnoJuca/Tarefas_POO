using System;
using System.Collections.Generic;
using System.Text;

namespace Conver_dolar
{
    class Conversor
    {

        public double cot_dolar;
        public double compra;
        double porc = 0.06;


        public double CalcCompra()
        {
            double valorCompra = cot_dolar * (compra + porc);
            return valorCompra;
        }

    }
}
