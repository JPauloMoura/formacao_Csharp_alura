using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaVick = new ContaCorrente();
            ContaCorrente contaJp = new ContaCorrente();

            contaVick.Sacar(10);
            Console.WriteLine(contaVick.saldo);

            contaVick.Sacar(100);
            Console.WriteLine(contaVick.saldo);

           
            Console.WriteLine("----Realizar transferência----");
            Console.WriteLine("Saldo vick: "+contaVick.saldo);
            Console.WriteLine("Saldo Jp: "+contaJp.saldo);

            contaVick.Transferir(50, contaJp);
            Console.WriteLine("----Sucesso!!!----");
            Console.WriteLine("Saldo vick: " + contaVick.saldo);
            Console.WriteLine("Saldo Jp: " + contaJp.saldo);

        }
    }
}
