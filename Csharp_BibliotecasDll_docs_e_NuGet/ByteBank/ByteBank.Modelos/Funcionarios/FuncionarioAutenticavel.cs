using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;
using ByteBank.Modelos;

namespace ByteBank.Funcionarios
{
    public abstract class FuncionarioAutenticavel: Funcionario, IAutenticavel
    {
        public string Senha { get; set; }

        private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();
        public FuncionarioAutenticavel(double salario, string cpf): base(salario, cpf) { }

        public bool Autenticar(string senhaTentativa)
        {
            return _autenticacaoHelper.CompararSenha(Senha, senhaTentativa);
        }
    }
}
