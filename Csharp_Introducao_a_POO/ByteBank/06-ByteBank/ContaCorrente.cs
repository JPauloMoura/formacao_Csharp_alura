namespace _06_ByteBank
{
    class ContaCorrente
    {
        public Cliente Titular { get; set; } //sem regra para manipular esse dado
        public int Agencia { get; set; }
        public int Numero { get; set; }
        private double _saldo = 100;

        public static int TotalDeContas { get; private set; }
        //construtor, obs que ele naoa tem um tipo de retorno
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            TotalDeContas++;
        }

        public bool Sacar(double valor)
        {
            if (_saldo > valor)
            {
                _saldo -= valor;
                return true;
            }

            return false;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (Sacar(valor))
            {
                contaDestino.Depositar(valor);
                return true;
            }
            return false;
        }

        // gets e sets
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