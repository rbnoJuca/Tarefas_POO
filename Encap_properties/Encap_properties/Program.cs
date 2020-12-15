using System;
using System.Globalization;

namespace Encap_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Coletando os dados do usuário */
            Console.WriteLine("Entre com os dados do produto: ");
            string nome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");
            Console.WriteLine("Quantidade: ");
            int qtde = int.Parse(Console.ReadLine());

            /* Utilizando sobrecarga */
            Produto produto = new Produto(nome, preco, qtde);

            /* Print na tela das informações coletadas */
            Console.WriteLine("Dados do produto: " + produto + "\n");

            /* Adiciona produtos */
            Console.WriteLine("Digite o número de produtos a serem adicionados: ");
            int _qtde = int.Parse(Console.ReadLine());
            produto.AdicionaProduto(_qtde);

            Console.WriteLine("Produto atualizado: " + produto + "\n");

            /* Remove produtos */
            Console.WriteLine("Informe o número de produtos a serem removidos: ");
            _qtde = int.Parse(Console.ReadLine());
            produto.RemoveProduto(_qtde);

            Console.WriteLine("Produtos atualizados: " + produto + "\n");

        }
    }
}
