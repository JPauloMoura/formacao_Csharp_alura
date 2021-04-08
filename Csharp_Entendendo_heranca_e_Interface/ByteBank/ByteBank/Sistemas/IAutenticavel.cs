using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Sistemas
{
    interface IAutenticavel
    {
        public bool Autenticar(string senha);
    }
}
