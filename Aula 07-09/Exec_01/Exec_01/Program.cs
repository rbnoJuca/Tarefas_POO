using System;
using System.Globalization;

namespace Exec_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Informe a largura do retangulo: ");
            retangulo.v_dLargura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");
            Console.WriteLine("Informe altura do retangulo: ");
            retangulo.v_dAltura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area: " +  );
        }
    }
}
