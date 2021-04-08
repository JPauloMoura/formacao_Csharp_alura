using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;
using ByteBank.Modelos;

namespace ByteBank.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
 
        public GerenteDeConta(string cpf): base(4000, cpf)
        {
            Console.WriteLine(">>criando gerente de conta...");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        internal protected override double GetBonificacao()
        {
            return Salario + 0.3;
        }
    }
}
