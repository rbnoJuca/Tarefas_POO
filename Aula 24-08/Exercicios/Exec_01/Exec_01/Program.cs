using System;

namespace Exec_01
{
    class Program
    {
        

        public static void Main(String[] args)
        {

            Pessoa x, y;

            x = new Pessoa();
            y = new Pessoa();
            

            Console.WriteLine("Digite o nome da pessoa: ");
            x.nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da pessoa: ");
            x.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da pessoa: ");
            y.nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da pessoa: ");
            y.idade = int.Parse(Console.ReadLine());

            if(x.idade > y.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + x.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: "+ y.nome);
            }

        }

    }
}
