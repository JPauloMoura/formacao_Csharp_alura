using System;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime diaDaFatura = new DateTime(2021, 3, 15);
            Console.WriteLine(diaDaFatura); // 15/03/2021 00:00:00

            DateTime hoje = DateTime.Now;
            Console.WriteLine(hoje); // 18/02/2021 15:31:54

            TimeSpan subtracaoDatas = diaDaFatura - hoje;
            Console.WriteLine(subtracaoDatas.Days);

            string dataFormatada = "Tempo restande: " + Humanizer.TimeSpanHumanizeExtensions.Humanize(subtracaoDatas);

            Console.WriteLine(dataFormatada); //Tempo restande: 3 semanas

        }
    }
}
