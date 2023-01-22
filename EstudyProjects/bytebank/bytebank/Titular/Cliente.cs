using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Titular
{
    internal class Cliente
    {
        private string nomeCliente { get; set; }
        
        private string cpfCliente;

        public string CpfCliente
        {
            get { return cpfCliente; }
            set { this.cpfCliente = value; }
        }
        public int IdadeCliente { get; set; }


        public string NomeCliente
        {
            get { return nomeCliente; }
            set
            {
                if (value.Length > 3)
                {
                    this.nomeCliente = value;
                }
                else
                {
                    Console.WriteLine("Nome do titular precisa ter pelo menos 3 caracteres.");
                }
            }



        }


        






    }






}
