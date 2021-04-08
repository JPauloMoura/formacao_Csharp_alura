using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente joao = new Cliente();
            joao.nome = "jp";
            joao.cpf = "071.678.987.90";
            joao.profissao = "Desenvolvedor";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = joao;
            conta.numero = 34622;
            conta.agencia = 144;
            conta.saldo = 200;

            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissao);
            Console.WriteLine(conta.numero);
            Console.WriteLine(conta.agencia);
            Console.WriteLine(conta.saldo);
        }
    }
}
