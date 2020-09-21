using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
        
            
            Funcionario funcionarioA = new Funcionario();
            Funcionario funcionarioB = new Funcionario();

            Console.WriteLine("Infome o nome do Primeiro Funcionário: ");
            funcionarioA.Nome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Informe o salário do Funcionário: ");
            funcionarioA.Salario = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Informe o Nome do Segundo Funcionário:");
            funcionarioB.Nome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Informe o salário do funcionário:");
            funcionarioB.Salario = double.Parse(Console.ReadLine());

            double media = (funcionarioA.Salario + funcionarioB.Salario) / 2;

            Console.WriteLine("Média salárial dos funcionários: " + media);

        }
    }
}
