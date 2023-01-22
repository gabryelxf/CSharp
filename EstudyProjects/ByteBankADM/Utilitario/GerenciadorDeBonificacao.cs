using ByteBankADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {

        public double TotalBonificacao { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            TotalBonificacao += funcionario.GetBonificacao();

        }

    }
}
