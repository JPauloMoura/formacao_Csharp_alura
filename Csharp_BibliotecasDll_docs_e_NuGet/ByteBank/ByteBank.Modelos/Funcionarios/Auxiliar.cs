using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(2000, cpf)
        {
            Console.WriteLine(">>criando auxiliar...");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

        protected internal override double GetBonificacao()
        {
            return Salario + 0.2;
        }
    }
}
