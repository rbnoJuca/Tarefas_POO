using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Coleta de informações para alimentar o objeto*/

            Console.WriteLine("Entre com os dados do produto.");
            Console.WriteLine("");
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Preço:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");
            Console.WriteLine("Quantidade em estoque:");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade); //Instanciação do objeto P

            Console.WriteLine("Dados do produto " + p);

            Console.WriteLine("Digite o número de produtos a ser adicionados ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.Adiciona(qte);//Chama método Adiciona()

            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine("Digite o número de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.Remover(qte);//Chama método Remover()

            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}
