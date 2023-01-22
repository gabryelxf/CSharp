using ByteBankADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankADM.Funcionarios
{
    internal class GerenteDeContas : FuncionarioAutenticavel
    {
        

        public GerenteDeContas(string cpf, double salario, string senha, string login) : base(cpf, salario, senha, login)
        {
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

       
    }
}
