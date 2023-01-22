using bytebank.Excecoes;
using bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Contas
{
    internal class ContaCorrente
    {
        //hgg
        /*kk*/
        public Cliente Titular { get;  set; }
        public readonly int Conta;

        private int agencia;
        public int Agencia
        {
            get
            {
                return agencia;
            }

            private set
            {
                if (value > 0)
                {
                    agencia = value;
                }
                
            }
        }

        private double saldo = 100;

            public double Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                this.saldo = value;
            }
        }

        public static double TaxaOperacao { get; private set; }
        public static int TotalContasCriadas { get; private set; }
        public static  int ContadorTransferenciasNaoPermitidas { get; set; }
        public ContaCorrente()
        {
            TotalContasCriadas++;
        }

        public ContaCorrente(Cliente titular, int conta, int agencia)
        {
            
            this.Titular = titular;
            this.Conta = conta;
            this.Agencia = agencia;
            TotalContasCriadas++;
            TaxaOperacao = 30 / TotalContasCriadas;

            if (conta <= 0)
            {
                throw new ArgumentException("O argumentos conta  precisa ser maior que zero!", nameof(conta));
            }

            if (agencia <= 0)
            {
                throw new ArgumentException("O argumento agencia precisa ser maior que zero!", nameof(agencia));
            }



        }


        public void depositar(double valor)
        {
            saldo += valor;
        }
        public bool sacar(double valor)
        {
            if (saldo <= valor)
            {
                throw new SaldoInsuficienteException("Saldo insuficiente no valor de " + valor);
               
            }

            saldo -= valor;
            return true;

        }

        public bool transferir(double valor, ContaCorrente contaCreditada)
        {

            try
            {
                sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFincanceiraException("Operação não realizada.", ex);

            }

            
                contaCreditada.depositar(valor);
                return true;
            


        }
      


    }
}
