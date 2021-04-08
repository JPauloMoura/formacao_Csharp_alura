using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }

        // sobrescrever metodo ToString
        public override string ToString()
        {
            return $"Cpf: {CPF}";
        }

        // sobrescrever metodo Equals
        public override bool Equals(object obj)
        {
            //convertendo obj para outro tipo, em caso de falha recebe null
            Cliente cliente = obj as Cliente;

            if (cliente != null)
            {
                return cliente.CPF == CPF;
            }

            return false;
        }
    }
}
