using System;

namespace Exerc_Extra
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point p = new Point(10,20);

            Point p1, p2, p3;

            p3 = new metodo1();

            p1.nome = "PS5";
            p1.preco = 1000;
            p1.qtde = 10;

            p2.nome = "Xbox One";
            p2.preco = 1200;
            p2.qtde = 10;

            p1 = p2;

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            
        }
        
    }
}
