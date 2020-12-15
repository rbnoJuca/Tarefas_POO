using System;
using System.Collections.Generic;

namespace Folha_Pagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            //bool funcTer = false;
            List<Funcionario> funcionarios = new List<Funcionario>();

            Console.WriteLine("Informe a quantidade de Funcionário: ");
            count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Funcionario funcionario = new Funcionario();

                Console.WriteLine("Informe o nome do Funcionário: ");
                funcionario.Nome = Console.ReadLine();

                Console.WriteLine("Informe quantas horas trabalhada: ");
                funcionario.Horas = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe valor por horas trabalha: ");
                funcionario.ValorHora = double.Parse(Console.ReadLine());

                Console.WriteLine("Funcionário é tercerizado? (Y/N): ");
                string confirma = Console.ReadLine();

                if(confirma == "Y")
                {
                    FuncionarioTercerizado funcionarioTercerizado = new FuncionarioTercerizado(funcionario.Nome,funcionario.Horas,funcionario.ValorHora);
                    Console.WriteLine("Informe o valor do adicional: ");
                    funcionarioTercerizado.Adicional = double.Parse(Console.ReadLine());
                    funcionarios.Add(funcionarioTercerizado);
                }
                else
                {
                    funcionarios.Add(funcionario);
                }
            }

            foreach (Funcionario obj in funcionarios)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
