using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_Extra
{
    struct Point
    {

        public string nome;
        public double preco;
        public int qtde;

        public override string ToString()
        {
            return "(produto: " + nome + ", preço: " + preco + ", quantidade: " + qtde + ")";
        }
        
        void metodo1()
        {
            int x = 10;
            if(x > 0)
            {
                int y = 20;
            }
            Console.WriteLine(x);
        }
    }
}
