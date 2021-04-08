using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ByteBank
{
    class LeitorDeArquivo : IDisposable
    {
        public string Arquivo { get; set; }
        public LeitorDeArquivo(string arquivo)
        {
            //throw new FileNotFoundException();
            Arquivo = arquivo;
            Console.WriteLine("Lendo arquivo");
        }

        public string LerProximaLinha()
        {
            throw new IOException();
            Console.WriteLine("Lendo linha...");
            return "Linha do arquivo";
        }

        /* public void Fechar()
         {
             Console.WriteLine("Arquivo fechado");
         }*/

        public void Dispose()
        {
            Console.WriteLine("Arquivo fechado");
        }
    }
}
