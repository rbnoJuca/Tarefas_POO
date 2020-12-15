using System;
using System.Globalization;
using System.Linq;

namespace Exerc_Array_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a qtde de produtos: ");
            int n = int.Parse(Console.ReadLine()); //Recebe a quantidade de produtos para criar o vetor.

            Produto[] prod = new Produto[n]; // cria o vetor apartir da informação recebida.

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Informe o nome do produto:");
                string nome = Console.ReadLine();
                Console.WriteLine("Informe o valor do produto:");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                prod[i] = new Produto { Nome = nome, Valor = valor }; //Insere os dados nos produtos criados pelo vetor
            }

            double sum = 0.0; //variável soma
            for(int i = 0; i < n; i++)
            {
                sum += prod[i].Valor;
            }

            Console.WriteLine("Preço médio: " + sum / prod.Length);
        }
    }
}
