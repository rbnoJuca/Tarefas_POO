using System;
using System.Collections.Generic;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Entrada do Usuário informando quantos funcionários são
            Console.WriteLine("Informe a quantidade de funcionários: ");
            int qtda = int.Parse(Console.ReadLine());

            //Cria a lista de funcionarios
            List<Funcionario> funcionarios = new List<Funcionario>();

            //de acordo com a quantidade de funcionário informado pelo usuário o loop é criado
            for (int i = 0; i < qtda; i++)
            {
                //funcionário instanciado
                Funcionario func = new Funcionario();
                
                //variavel para verificação se o ID se repete
                bool verificaId = false;

                //loop para verificação do ID do funcionário
                do
                {
                    if(verificaId == true)
                    {
                        Console.WriteLine("Id já utilizado, informe outro: ");
                    }
                    Console.WriteLine("Informe o ID do funcionário: ");
                    func.Id = int.Parse(Console.ReadLine());
                    verificaId = funcionarios.Exists(x => x.Id == func.Id);

                } while (verificaId == true);

                //Entrada do nome do funcionário
                Console.WriteLine("Informe o nome do funcionário: ");
                func.Nome = Console.ReadLine();

                //Entrada do salário do funcionário
                Console.WriteLine("Informe o salário do funcionário: ");
                func.Salario = double.Parse(Console.ReadLine());

                //funcionário adicionado a lista criada
                funcionarios.Add(func);
            }

            //entrada do ID para realizar o aumento
            Console.WriteLine("Informe o ID do funcionário que receberá aumento: ");
            int id = int.Parse(Console.ReadLine());

            //Busca do ID do funcionário
            if(funcionarios.Exists(x => x.Id == id))
            {
                Console.WriteLine("Qual o aumento do funcionário: ");
                double porcent = double.Parse(Console.ReadLine());
                
                //armazenamento do ID para fazer o aumento
                int pos = funcionarios.FindIndex(x => x.Id == id);
                funcionarios[pos].aumentaSalario(porcent);
            }
            else
            {
                Console.ReadKey();
            }

            //impressão na tela da lista de funcionários.
            foreach (Funcionario obj in funcionarios)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
