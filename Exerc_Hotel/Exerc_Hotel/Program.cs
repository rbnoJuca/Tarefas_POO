using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Exerc_Hotel
{
    class Program
    {


        static void Main(string[] args)
        {
            Hospede[] quarto = new Hospede[10];

            Console.WriteLine("Informe quantos hospedes irão se hospedar: ");
            int alug = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Hospede> lista = new List<Hospede>();

            for (int i = 0; i < alug; i++)
            {
                Hospede cliente = new Hospede();

                Console.WriteLine("Informe o nome do cliente: ");
                cliente.Nome = Console.ReadLine();

                Console.WriteLine("informe o e-mail do cliente: ");
                cliente.Email = Console.ReadLine();

                bool cheking = false;

                do
                {
                    Console.WriteLine("Escolha o quarto: ");
                    for (int j = 0; j < 10; j++)
                    {
                        if (quarto[j] == null)
                        {
                            Console.Write(" Quarto: " + j.ToString() + " - Vago |");
                        }
                        else
                        {
                            Console.Write(" Quarto: " + j.ToString() + " - Ocupado |");
                        }
                    }
                    Console.Write("\n");
                    int numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    if (quarto[numero] == null)
                    {
                        quarto[numero] = cliente;
                        cheking = true;
                    }
                    else
                    {
                        Console.WriteLine("Quarto ocupado!");
                    }
                } while (cheking == false);

            }

            int count = 0;
            for (int j = 0; j < 10; j++)
            {
                if (quarto[j] != null)
                {
                    count++;
                }
            }
            Console.WriteLine("Quantos quartos estão alugados? " + count);

            count = 1;
            string listaHospide = "";
            for (int j = 0; j < 10; j++)
            {
                if (quarto[j] != null)
                {
                    Console.WriteLine("Hospede #" + count.ToString());
                    Console.WriteLine("Nome: " + quarto[j].Nome);
                    Console.WriteLine("E-Mail: " + quarto[j].Email);
                    Console.WriteLine("");
                    Console.WriteLine("Quarto: " + j);
                    Console.WriteLine("-----------------------------------------------");
                    count++;
                    listaHospide += j.ToString() + ": " + quarto[j].Nome + ", " + quarto[j].Email + "\n";
                }
            }

            Console.WriteLine("Quartos Ocupados");
            Console.WriteLine(listaHospide);

        }
    }
}
