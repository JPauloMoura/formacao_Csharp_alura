using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf): base(4000, cpf)
        {
            Console.WriteLine(">>criando gerente de conta...");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        public override bool Autenticar(string senha)
        {
            return Senha == senha;
        }

        public override double GetBonificacao()
        {
            return Salario + 0.3;
        }
    }
}
