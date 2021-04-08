using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaJose = new ContaCorrente();
            ContaCorrente contaPaulo = new ContaCorrente();

            Console.WriteLine("Conta de paulo é igual a de jose?");
            Console.WriteLine(contaPaulo == contaJose);

            // adicionando a mesma referencia
            contaJose = contaPaulo;

            Console.WriteLine("Conta de paulo é igual a de jose?");
            Console.WriteLine(contaPaulo == contaJose);

            //alterando o saldo de jose
            contaJose.saldo = 666;
            Console.WriteLine("Saldo de jose: "+ contaJose.saldo);
            Console.WriteLine("Saldo de paulo: "+ contaPaulo.saldo);

            //alterando o saldo de paulo
            contaPaulo.saldo = 900;
            Console.WriteLine("Saldo de jose: "+ contaJose.saldo);
            Console.WriteLine("Saldo de paulo: "+ contaPaulo.saldo);

            //OBS: sempre que alterarmos o valor de um obj
            //irá refletir no outro, pois eles tem a mesma referencia de memória



        }
    }
}
