using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Produto
    {
        private string nome;
        public string Nome { get => nome; set => nome = value; }

        private double preco;
        public double Preco { get => preco; set => preco = value; }

        private int quantidade;
        public int Quantidade 
        { 
            get => quantidade;
            set
            {
                quantidade = value;
                Total = quantidade * Preco;
            }
        }

        private double total;
        public double Total { get => total; set => total = value; }

        public string ExibirProduto()
        {
            string v_sProduto = "Dados do Produto: " + Nome + ", R$ " + Preco.ToString() + ", " + Quantidade.ToString() + " unidades, Total: R$" + Total.ToString();
            return v_sProduto;
        }

        public void Adicionar(int p_iQtd)
        {
            Quantidade = Quantidade + p_iQtd;
        }

        public void Remover(int p_iQtd)
        {
            Quantidade = Quantidade - p_iQtd;
        }

    }
}
