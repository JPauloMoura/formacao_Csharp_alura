using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool isAutenticado = funcionario.Autenticar(senha);

            if (isAutenticado)
            {
                Console.WriteLine("Sucesso!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha inválida");
                return false;
            }
        }
    }
}
