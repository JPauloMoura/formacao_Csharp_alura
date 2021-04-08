using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    internal class AutenticacaoHelper
    {
        public bool CompararSenha(string senhaOriginal, string senhaTentativa)
        {
            if(senhaOriginal == senhaTentativa)
            {
                Console.WriteLine("Usuário Autenticado!!!");
                return true;
            }
            Console.WriteLine("Senha inválida!!!");
            return false;
        }
    }
}
