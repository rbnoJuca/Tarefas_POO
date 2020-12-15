using System;

namespace Exec_02
{
    class Program
    {
        public static void Main(string[] args)
        {
            Produto x;

            x = new Produto();

            Console.WriteLine("Informe o nome do produto: ");
            x.s_Nome = Console.ReadLine();
            Console.WriteLine("Informe o preço do produto: ");
            x.d_Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de produto: ");
            x.i_Qtda = int.Parse(Console.ReadLine());


            
            Console.WriteLine("dados do Produto: " + x.s_Nome + ", R$ " + x.d_Preco + " " + x.i_Qtda + " Unidades, Total: " + x.d_Total);

        }
    }
}
