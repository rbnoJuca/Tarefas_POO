using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            string v_sOpcao = "";
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("");
                Console.WriteLine("1 - Cadastrar Produto");
                Console.WriteLine("");
                Console.WriteLine("2 - Adicionar Produto");
                Console.WriteLine("");
                Console.WriteLine("3 - Remover Produto");
                Console.WriteLine("");
                Console.WriteLine("5 - Sair");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Lista de Produto");
                Console.WriteLine(produto.ExibirProduto());
                v_sOpcao = Console.ReadLine();

                switch(v_sOpcao)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do produto: ");
                        produto.Nome = Console.ReadLine();
                        Console.WriteLine("Informe o preço do produto: ");
                        produto.Preco = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a quantidade de produto: ");
                        produto.Quantidade = int.Parse(Console.ReadLine());
                        break;
                    case "2":
                        Console.WriteLine("Informe a quantidade de produto para adiconar: ");
                        produto.Adicionar(int.Parse(Console.ReadLine()));
                        break;
                    case "3":
                        Console.WriteLine("Informe a quantidade de produto para remover: ");
                        produto.Remover(int.Parse(Console.ReadLine()));
                        break;
                }
            } while (v_sOpcao != "5");

            Console.ReadLine();
        }
    }
}
