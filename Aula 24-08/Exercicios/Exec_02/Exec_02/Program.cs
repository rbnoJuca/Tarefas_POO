using System;
using System.Net.Http.Headers;

namespace Exec_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario x, y;

            x = new Funcionario();
            y = new Funcionario();

            Console.WriteLine("Nome do funcionário: ");
            x.nome = Console.ReadLine();
            Console.WriteLine("Informe o salário do funcionário: ");
            x.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Nome do funcionário: ");
            y.nome = Console.ReadLine();
            Console.WriteLine("Informe o salário do funcionário: ");
            y.salario = double.Parse(Console.ReadLine());

            double media = (x.salario + y.salario) / 2;

            Console.WriteLine("A média salarial é: " + media);
        }
    }
}
