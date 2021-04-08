using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    class Diretor : FuncionarioAutenticavel, IAutenticavel
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine(">>criando diretor...");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override bool Autenticar(string senha)
        {
            return Senha == senha;
        }

        public override double GetBonificacao()//override: significa que esse metodo é uma sobrescrita
        {
            return Salario + Salario;
        }
    }
} 
