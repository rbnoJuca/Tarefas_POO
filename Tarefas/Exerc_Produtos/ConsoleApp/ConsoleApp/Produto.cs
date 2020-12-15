using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Produto
    {
        private string nome;
        private double preco;
        private int quantidade;
        private double total;


        public string Nome { get => nome; set => nome = value; }
        
        public double Preco { get => preco; set => preco = value; }
        
        public int Quantidade 
        { 
            get => quantidade;
            set
            {
                quantidade = value;
                Total = quantidade * Preco;
            }
        }
                
        public double Total { get => total; set => total = value; }

        public string ExibirProduto()
        {

            string v_sProduto = "Dados do Produto: " 
                    + Nome 
                    + ", R$ " 
                    + Preco.ToString("F2",CultureInfo.InvariantCulture) 
                    + ", " 
                    + Quantidade.ToString() 
                    + " unidades, Total: R$" 
                    + Total.ToString("F2", CultureInfo.InvariantCulture);

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
