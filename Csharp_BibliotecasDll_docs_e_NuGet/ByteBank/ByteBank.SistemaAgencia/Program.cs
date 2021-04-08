using System;
using ByteBank.Modelos;
using ByteBank.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(12,21);
            Console.WriteLine(conta.Numero);
            Diretor diretor = new Diretor("123");
            diretor.Senha = "1234";
            diretor.Autenticar("122");
        }
    }
}
