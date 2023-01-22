using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankADM.SistemaInterno
{
    public class SistemaInterno
    {

        public bool Logar(IAutenticavel funcionario, string senha, string login)
        {

            if (funcionario.Autenticar(senha, login))
            {

                Console.WriteLine("Boas vindas ao sistema");
                return true;
            }
            else{
                Console.WriteLine("Não foi possível logar");
                return false;
            }

        }

    }
}
