using ByteBankADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankADM.SistemaInterno
{
    public interface IAutenticavel

    {

        protected string Senha {get;set;}  
        public string Login { get; set; }

        public bool Autenticar(string senha, string login);
        

        
    }
}
