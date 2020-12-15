using System;
using System.Collections.Generic;
using System.Text;

namespace Folha_Pagamento
{
    class FuncionarioTercerizado : Funcionario
    {

        double adicional;

        public double Adicional
        {
            get => adicional;
            set => adicional = value;
        }


        public FuncionarioTercerizado() { }

        public FuncionarioTercerizado(string Nome, int Horas, double ValorHora) : base(Nome, Horas, ValorHora)
        {

        }

        public double pagamento()
        {
            return adicional = adicional * 1.1;
        }

        public override string ToString()
        {
            return "Nome: " + Nome
                  +"\nHoras: " + Horas
                  +"\nValor Horas: " + ValorHora
                  +"\nAdicional: " + adicional
                  +"\nValor pago: " + ((Horas * ValorHora) + pagamento());
        }
    }
}
