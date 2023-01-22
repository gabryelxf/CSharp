using ByteBankADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {

        public Diretor(string cpf, double salario, string senha, string login) : base(cpf, salario, senha, login)
        {
        }


        public override double GetBonificacao()
        {
            return this.Salario * 0.5;
        }


        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

       /* public override bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }*/
    }
}
