using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel, IAutenticavel
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine(">>criando diretor...");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        internal protected override double GetBonificacao()//override: significa que esse metodo é uma sobrescrita
        {
            return Salario + Salario;
        }
    }
} 
