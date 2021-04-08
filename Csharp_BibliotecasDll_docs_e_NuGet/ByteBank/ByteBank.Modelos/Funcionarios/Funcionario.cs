using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; protected set; }

        public static int QtdDeFuncionarios { get; private set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine(">>criando funcionario...");
            Salario = salario;
            Cpf = cpf;
            QtdDeFuncionarios++;
        }
        public abstract void AumentarSalario();
        internal protected abstract double GetBonificacao();
    }
}
