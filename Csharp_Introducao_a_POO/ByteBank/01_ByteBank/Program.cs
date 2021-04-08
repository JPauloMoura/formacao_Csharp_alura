using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoJoao = new ContaCorrente();
            contaDoJoao.titular = "joao";
            contaDoJoao.agencia = 189;
            contaDoJoao.numero = 900765;
            contaDoJoao.saldo = 100;

            Console.WriteLine(contaDoJoao.titular);
            Console.WriteLine(contaDoJoao.agencia);
            Console.WriteLine(contaDoJoao.numero);
            Console.WriteLine(contaDoJoao.saldo);
        }
    }
}
