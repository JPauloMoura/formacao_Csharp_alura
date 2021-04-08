using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            UsarSistema();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor jp = new Diretor("765.987.678-09");
            jp.Senha = "123";

            GerenteDeConta mateus = new GerenteDeConta("765.987.678-09");
            mateus.Senha = "123";

            ParceiroComercial parceiroComercial = new ParceiroComercial();
            parceiroComercial.Senha = "0000";

            sistemaInterno.Logar(jp, "123");
            sistemaInterno.Logar(mateus, "123");
            sistemaInterno.Logar(parceiroComercial, "000");
        }
        public static void Teste()
        {
            Funcionario diretor = new Diretor("876.345.567-90");
            Funcionario gerenteDeContagerenteDeConta = new GerenteDeConta("876.345.567-90");
            Funcionario designer = new Designer("876.345.567-90");
            Funcionario auxiliar = new Auxiliar("876.345.567-90");

            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();
            gerenciadorBonificacao.Registrar(diretor);
            gerenciadorBonificacao.Registrar(gerenteDeContagerenteDeConta);
            gerenciadorBonificacao.Registrar(designer);
            gerenciadorBonificacao.Registrar(auxiliar);
  
            diretor.Nome = "Fernando";
            gerenteDeContagerenteDeConta.Nome = "Bruna";
            designer.Nome = "Mangovile";
            auxiliar.Nome = "Peixada";
        }
    }
}
