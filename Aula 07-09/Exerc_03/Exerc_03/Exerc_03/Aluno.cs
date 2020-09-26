using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_03
{
    class Aluno
    {
        public string nome;
        public double nota_1;
        public double nota_2;
        public double nota_3;

        public double SomaNota()
        {
            double soma = nota_1 + nota_2 + nota_3;
            return soma;            
        }

    }
}
