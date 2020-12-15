using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo trianguloA = new Triangulo();
            Triangulo trianguloB = new Triangulo();

            Console.WriteLine("Informe o primeiro lado do triangulo: ");
            trianguloA.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Informe o segundo lado do triangulo: ");
            trianguloA.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o terceiro lado do triangulo: ");
            trianguloA.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);





            //Console.WriteLine("Primeiro angulo " + trianguloA.A + ", Segundo angulo " + trianguloA.B + ", Terceiro angulo " + trianguloA.C);

        }
    }
}