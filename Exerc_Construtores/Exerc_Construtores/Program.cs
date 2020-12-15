using System;
using System.Globalization;

namespace Exerc_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Coletando os dados do usuário */
            Console.WriteLine("Entre com os dados do produto;");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int qtde = int.Parse(Console.ReadLine());

            /* Utilizando sobrecarga */
            Produtos p = new Produtos(nome, preco, qtde);

            /* Print na tela das informações coletadas */
            Console.WriteLine("Dados do produto: " + p);

            /* Adiciona produtos */
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);

            Console.WriteLine("Dados atualizados: " + p);

            /* Remove Produtos */
            Console.WriteLine("Digite o número de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);

            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
