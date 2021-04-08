using System;
using System.IO;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch (Exception)
            {
                Console.WriteLine("exceção no  metodo Main");
            }

        }

        private static void CarregarContas()
        {
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("meu arquivo"))
            {
                leitor.LerProximaLinha();
            }

            /*LeitorDeArquivo leitorDeArquivo = null;
            try
            {
                leitorDeArquivo = new LeitorDeArquivo("meu arquivo");
                leitorDeArquivo.LerProximaLinha();
                leitorDeArquivo.LerProximaLinha();
            }
            catch (IOException )
            {
                Console.WriteLine("arquivo não encontrado");
            }
            finally
            {   
                if(leitorDeArquivo != null)
                {
                    leitorDeArquivo.Fechar();
                }
            }*/
        } 
        
        private static void TestarInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(1, 1);
                ContaCorrente conta2 = new ContaCorrente(2, 2);
                conta1.Transferir(900000, conta2);
                Console.WriteLine("-->" + conta1.ContadorSaquesNaoPermitidos);
            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.InnerException.StackTrace);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
