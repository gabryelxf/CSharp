using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankADM.Funcionarios
{
    internal class Designer : Funcionario
    {
        public Designer(string cpf, double salario) : base(cpf, salario)
        {
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.17;
        }
    }
}
