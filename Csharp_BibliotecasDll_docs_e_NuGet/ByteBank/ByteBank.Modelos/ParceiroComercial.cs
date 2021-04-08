using ByteBank.Sistemas;
using System;
using ByteBank.Modelos;
namespace ByteBank
{
    public class ParceiroComercial : IAutenticavel
    {
        private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();
        public string Senha { get; set; }
        public bool Autenticar(string senhaTentativa)
        {
            return _autenticacaoHelper.CompararSenha(Senha, senhaTentativa);
        }
    }

}
