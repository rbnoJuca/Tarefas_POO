using System;
using System.Collections.Generic;
using System.Globalization;

namespace Banco.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria a lista de contas
            List<Conta> list = new List<Conta>();

            //Populando a lista com as contas
            list.Add(new ContaPoupanca(1001, "Terry", 500.0, 0.01));
            list.Add(new ContaJuridica(1002, "Andy", 500.0, 400.0));
            list.Add(new ContaPoupanca(1003, "Joe", 500.0, 0.01));
            list.Add(new ContaJuridica(1004, "Mae", 500.0, 400.0));

            double sum = 0.0;
            //para cada conta da lista 
            foreach(Conta acc in list)
            {
                //soma o saldo das contas da lista
                sum += acc.Saldo;
            }

            //printa na tela a soma das listas
            Console.WriteLine("Total do saldo de todas as contas: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            //saque do valor estipulado nas contas da lista
            foreach(Conta acc in list)
            {
                acc.Saque(10.0);
            }

            //printa na tela o valor do saldo das contas atualizado
            foreach(Conta acc in list)
            {
                Console.WriteLine("Atualização do saldo das contas: " + acc.Numero + ": " + acc.Saldo.ToString("F2",CultureInfo.InvariantCulture));
            }
                        
            ContaJuridica bacc = new ContaJuridica(1002, "Goten", 0.0, 500.0);

            //UPCASTING

            Conta acc1 = bacc;
            Conta acc2 = new ContaJuridica(1003, "Trunks", 0.0, 500.0);
            Conta acc3 = new ContaPoupanca(1004, "Vegeta", 0.0, 0.01);

            //DOWNCASTING

            ContaJuridica acc4 = (ContaJuridica)acc2;
            acc4.Emprestimo(100);

            if(acc3 is ContaJuridica)
            {
                ContaJuridica acc5 = (ContaJuridica)acc3;
                acc5.Emprestimo(200);
                Console.WriteLine("Emprestimo!");
            }

            if(acc3 is ContaPoupanca)
            {
                ContaPoupanca acc5 = acc3 as ContaPoupanca;
                acc5.atualizacaoSaldo();
                Console.WriteLine("Atualizado!");
            }
        }
    }
}
