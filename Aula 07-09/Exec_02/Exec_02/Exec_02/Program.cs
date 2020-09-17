using System;

namespace Exec_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Informe o nome do funcionário: ");
            funcionario.v_sNome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Informe o salário bruto: ");
            funcionario.v_dSalarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Informoe o imposto: ");
            funcionario.v_dImposto = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Funcionário: " + funcionario.v_sNome + ", R$ " + funcionario.SalarioLiquido().ToString());

            Console.WriteLine("Informe a porcentagem para o aumento: ");
            funcionario.v_dAttSal = double.Parse(Console.ReadLine());

            Console.WriteLine(funcionario.AumentarSalario());

        }
    }
}
