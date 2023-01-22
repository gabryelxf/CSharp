using ByteBankADM.Funcionarios;
using ByteBankADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankADM.Parceria
{
    public class ParceiroComercial : FuncionarioAutenticavel
    {
        public ParceiroComercial(string cpf, double salario, string senha, string login) : base(cpf, salario, senha, login)
        {
        }

        public override void AumentarSalario()
        {
            throw new NotImplementedException();
        }

        public override double GetBonificacao()
        {
            throw new NotImplementedException();
        }
    }
}
