using ByteBankADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {

        public string Senha { get; set ; }
        public string Login { get; set; }


        public FuncionarioAutenticavel(string cpf, double salario, string senha, string login) : base(cpf, salario)
        {
            this.Senha = senha;
            this.Login = login;
        }

        public bool Autenticar(string senha, string login)
       {
            return this.Senha == senha && this.Login == login;
        }

}
}
