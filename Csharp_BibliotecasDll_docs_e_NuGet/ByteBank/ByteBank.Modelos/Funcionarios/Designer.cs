using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(3000, cpf)
        {
            Console.WriteLine(">>criando designer...");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }

        internal protected override double GetBonificacao()
        {
            return Salario + 0.2;
        }
    }
}
