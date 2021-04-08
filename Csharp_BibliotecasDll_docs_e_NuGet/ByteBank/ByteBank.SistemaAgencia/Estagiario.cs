using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.SistemaAgencia
{
    class Estagiario : Funcionario
    {
        
        public Estagiario(double salario, string cpf):base(salario, cpf)
        {
        
        }

        public override void AumentarSalario()
        {
            throw new NotImplementedException();
        }

        protected override double GetBonificacao()
        {
            throw new NotImplementedException();
        }
    }

}
