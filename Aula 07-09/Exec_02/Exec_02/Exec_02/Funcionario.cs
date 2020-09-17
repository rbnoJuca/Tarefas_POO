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
        public double v_dAttSal;

        public double SalarioLiquido()
        {
            double v_dSalLiqui = v_dSalarioBruto - v_dImposto;
            return v_dSalLiqui;
        }

        public void AumentarSalario(double attSal)
        {
            attSal = SalarioLiquido() + (v_dSalarioBruto * v_dAttSal);
            return attSal;
        }
    }
}
