﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Excecoes
{
    public class SaldoInsuficienteException : OperacaoFincanceiraException
    {
        public SaldoInsuficienteException(string mensagem):base(mensagem) 
        {

        }

    }
}
