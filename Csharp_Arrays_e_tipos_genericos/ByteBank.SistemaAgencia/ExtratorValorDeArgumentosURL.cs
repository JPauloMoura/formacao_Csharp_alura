using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos; // caminho que aparece apos "?" da url 
        public string Url { get; }

        public ExtratorValorDeArgumentosURL(string url)
        {
            if (String.IsNullOrEmpty(url)) throw new ArgumentException("não pode ser nulo nem vazio",nameof(url));
            
            Url = url;
            
            int indexInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indexInterrogacao + 1);
        }

        public string GetValor(string param)
        {
            string argumentoUpper = _argumentos.ToUpper();
            string parmLower = param.ToUpper();

            // _argumentos = moedaOrigem=real&moedaDestino=dolar
            string termo = parmLower + '='; // moedaOrigem= || moedaDestino=
            int indexTermo = argumentoUpper.IndexOf(termo);

            string resultado = _argumentos.Substring(indexTermo + termo.Length); //real&moedaDestino=dolar || dolar
            int indexEComercia = resultado.IndexOf('&');

            if(indexEComercia != -1)
            {
                return resultado.Remove(indexEComercia);
            }
     
            return resultado;
        }
    }
}
