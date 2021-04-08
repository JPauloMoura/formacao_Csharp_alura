using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo { get; }
        public double ValorSaque { get; }
        public SaldoInsuficienteException()
        {

        }

        public SaldoInsuficienteException(double saldo, double valorSaque)
           : this("Não é permitido saque de R$"+valorSaque+" em um saldo de R$"+saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

        public SaldoInsuficienteException(string mensage): base(mensage)
        {
 
        }
    }
}
