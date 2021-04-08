using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    abstract class FuncionarioAutenticavel: Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        public FuncionarioAutenticavel(double salario, string cpf): base(salario, cpf) { }

        public abstract bool Autenticar(string senha);
    }
}
