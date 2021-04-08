using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente joao = new Cliente();
            joao.Nome = "jp";
            Console.WriteLine(ContaCorrente.TotalDeContas);
            ContaCorrente conta = new ContaCorrente(123, 98987);
            conta.Titular = joao;

            conta.Saldo = 200;
            conta.Numero = 8989;

            Console.WriteLine(ContaCorrente.TotalDeContas);
            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Numero);
        }
    }
}
