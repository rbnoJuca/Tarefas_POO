using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

namespace Conver_dolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversor conv = new Conversor();

            Console.WriteLine("Informe a cotação do dolar: ");
            conv.cot_dolar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Informe a quantidade de dolares a comprar: ");
            conv.compra = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("O valor a ser pago em reais = R$:" + conv.CalcCompra(),"F2", CultureInfo.InvariantCulture);

        }
    }
}
