using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            try
            {
                ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(url);

                string moedaOrigem = extrator.GetValor("mOedaOrigem");
                Console.WriteLine("Moeda origem: " + moedaOrigem);

                string moedaDestino = extrator.GetValor("MoedaDestino");
                Console.WriteLine("Moeda destino: " + moedaDestino);
                Console.WriteLine("-------------------------------------");

                ContaCorrente conta = new ContaCorrente(123, 98989);
                ContaCorrente conta2 = new ContaCorrente(113, 98989);
                Console.WriteLine(conta.GetType());
                Console.WriteLine(conta.Equals(conta2));
                Console.WriteLine(conta.GetHashCode()); //46104728
                Console.WriteLine(conta.ToString()); 

            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

         
            Console.ReadLine();

        }
    }


}
