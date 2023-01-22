using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankADM.Funcionarios
{
    public class Auxiliar : Funcionario
    {
       

        public Auxiliar(string cpf, double salario) : base(cpf, salario)
        {
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.2;
        }
    }
}
