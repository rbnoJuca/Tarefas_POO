namespace Exec_02
{
    internal class Produto
    {

        public string s_Nome;
        public double d_Preco;
        public int i_Qtda;
        public double d_Total;

        public void adiciona(int qtdAdicionar)
        {
            i_Qtda = i_Qtda + qtdAdicionar;
            d_Total = i_Qtda * d_Preco;
        }
        
        public void remove()
        {

        }
    }
}