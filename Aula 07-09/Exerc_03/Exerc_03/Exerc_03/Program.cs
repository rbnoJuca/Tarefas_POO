using System;

namespace Exerc_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Informe o aluno: ");
            aluno.nome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Primeira nota - pontuação máxima: 30.\nSegunda nota - pontuação máxima: 35.\nTerceira nota - pontuação máxima: 35.");
            Console.WriteLine("");
            do
            {
                Console.WriteLine("Informe a primeira nota do aluno: ");
                aluno.nota_1 = double.Parse(Console.ReadLine());
            }
            while (aluno.nota_1 < 0 || aluno.nota_1 > 30);

            do
            {
                Console.WriteLine("Informe a segunda nota do aluno: ");
                aluno.nota_2 = double.Parse(Console.ReadLine());
            }
            while (aluno.nota_2 < 0 || aluno.nota_2 > 35);

            do
            {
                Console.WriteLine("informe a terceira nota do aluno: ");
                aluno.nota_3 = double.Parse(Console.ReadLine());
            }
            while (aluno.nota_3 < 0 || aluno.nota_3 > 35);


            if (aluno.SomaNota() >= 60)
            {
                Console.WriteLine("Aluno Aprovado.\nPontuação do aluno: " + aluno.SomaNota() + " pontos.");
            }
            else
            {
                Console.WriteLine("Aluno Reprovado.\nFaltaram " + (100 - aluno.SomaNota()) + " pontos.");
            }

        }
    }
}
