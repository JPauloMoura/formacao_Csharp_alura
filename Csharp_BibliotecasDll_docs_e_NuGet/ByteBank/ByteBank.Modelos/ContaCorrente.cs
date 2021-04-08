using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; set; }
        public Cliente Titular { get; set; }
        public int Numero { get; }
        public int Agencia { get; }
        private double _saldo = 100;
        public static int TotalDeContas { get; private set; }
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        public ContaCorrente(int agencia, int numero)
        {
            if(agencia <= 0)
            {
                ArgumentException exception = new ArgumentException("Numero da Agencia deve se maior que 0", nameof(numero));
                throw exception;
            }

            if (numero <= 0)
            {
                ArgumentException exception = new ArgumentException("Numero da Conta deve se maior que 0", nameof(numero)) ;
                throw exception;
            }

            Agencia = agencia;
            Numero = numero;
            TotalDeContas++;

            TaxaOperacao = 30 / TotalDeContas;
        }

        public void Sacar(double valor)
        {
            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(_saldo, valor);
            }

            if(valor <= 0)
            {
                throw new ArgumentException("O valor do saque deve ser maior que Zero", nameof(valor));
            }

            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("O valor do transferencia deve ser maior que Zero", nameof(valor));
            }

            try
            {
                Sacar(valor);   
            }
            catch (SaldoInsuficienteException e)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não permitida", e);
            }

            contaDestino.Depositar(valor);
        }

        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if (value > 0)
                {
                    _saldo = value;
                }
            }
        }

    }
}