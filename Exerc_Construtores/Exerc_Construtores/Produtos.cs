using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exerc_Construtores
{
    class Produtos
    {

        public string Nome;
        public double Preco;
        public int Qtde;

        public Produtos(string nome, double preco, int qtde)
        {
            Nome = nome;
            Preco = preco;
            Qtde = qtde;
        }

        public double ValorTotalEstoque()
        {
            return Preco * Qtde;
        }

        public void AdicionarProduto(int _qtde)
        {
            Qtde += _qtde;
        }

        public void RemoverProduto(int _qtde)
        {
            Qtde -= _qtde;
        }

        public override string ToString()
        {
            return Nome
                + ", R$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Qtde
                + " unidades, Total: R$ "
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
