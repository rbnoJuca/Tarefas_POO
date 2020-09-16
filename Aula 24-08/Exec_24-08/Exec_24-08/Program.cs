using System;

namespace Exec_24_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoaX = new Pessoa();
            Pessoa pessoaY = new Pessoa();

            Console.WriteLine("Informe o nome da primeira pessoa: ");
            pessoaX.nome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Informe a idade da primeira pessoa: ");
            pessoaX.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Informe o nome da segunda pessoa: ");
            pessoaY.nome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Informe a idade da segunda pessoa: ");
            pessoaY.idade = int.Parse(Console.ReadLine());

            if(pessoaX.idade > pessoaY.idade)
            {
                Console.WriteLine("A pessoa mais velha é " + pessoaX.nome);
            }
            else
            {
                Console.WriteLine("A pessoa mais velha é " + pessoaY.nome);
            }
        }
    }
}
