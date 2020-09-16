using System;
using System.Globalization;

namespace Aula_24_08_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double media;

            Pessoa pessoaX = new Pessoa();
            Pessoa pessoaY = new Pessoa();

            Console.WriteLine("Informe o nome da primeira pessoa: ");
            pessoaX.nome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Informe o salário da primeira pessoa: ");
            pessoaX.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("");
            Console.WriteLine("Informe o nome da segunda pessoal: ");
            pessoaY.nome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Informe o salário da segunda pessoa: ");
            pessoaY.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");

            media = (pessoaY.salario + pessoaX.salario) / 2;

            Console.WriteLine("A média salárial é: " + media);

        }
    }
}
