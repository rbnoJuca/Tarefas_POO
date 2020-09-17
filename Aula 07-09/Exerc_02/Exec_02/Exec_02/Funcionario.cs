using System;
using System.Collections.Generic;
using System.Text;

namespace Exec_02
{
    class Funcionario
    {

        public string v_sNome;
        public double v_dSalarioBruto;
        public double v_dImposto;

        public double SalarioLiquido()
        {
            double v_dSalLiqui = v_dSalarioBruto - v_dImposto;
            return v_dSalLiqui;
        }

        public void AumentarSalario(double p_dAttSal)
        {

            v_dSalarioBruto = SalarioLiquido() + (v_dSalarioBruto * (p_dAttSal/100));

        }
    }
}
