using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    class Produto
    {

        public string Nome;
        public double Preco;
        public int Quantitade;

        public Produto(string nome, double preco, int quantitade) //método construtor.
        {
            Nome = nome;
            Preco = preco;
            Quantitade = quantitade;
        }


        public double ValorTotalEstoque() //calculo do valor de estoque.
        {
            return Preco * Quantitade;
        }

        public void Adiciona(int quantitade) //adiciona peças ao estoque.
        {
            Quantitade += quantitade;
        }

        public void Remover(int quantidade) //remove peças do estoque.
        {
            Quantitade = Quantitade - quantidade;
        }

        public override string ToString() //método de ToString para impressão de informações.
        {
            return Nome
                + ", R$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantitade
                + " unidades, Total: R$ "
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
