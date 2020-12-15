using System;
using System.Globalization;

namespace Exec_Array_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            int pessoa;

            Console.WriteLine("Entre com um número de pessoas: ");
            pessoa = int.Parse(Console.ReadLine()); //valor a ser inserido pelo usuário.
            double[] vect = new double[pessoa]; //Tamanho do vetor definido pelo usuário.

            //Criação do laço do vetor conforme o tamanho definido pelo usuário.
            Console.WriteLine("Informe a altura da pessoa: ");

            for (int i = 0; i < pessoa; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Altura da pessoa " + "(" + i + "): " + vect[i]);
            }

            //Variável soma
            double sum = 0.0;

            //Utilização do for para percorrer o vetor.
            for(int i = 0; i < pessoa; i++)
            {
                sum += vect[i];
            }

            Console.WriteLine("A média de altura das pessoas inseridas é = " + sum/pessoa);
        }
    }
}
