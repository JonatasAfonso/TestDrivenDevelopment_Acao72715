using System;

namespace Projeto.LogicaNegocio
{
    public class Funcionario
    {
        public string Nome { get; private set; }
        public double Salario { get; private set; }
        public Cargo Cargo { get; private set; }

        public Funcionario(string Nome, double Salario, Cargo Cargo)
        {
            this.Nome = Nome;
            this.Salario = Salario;
            this.Cargo = Cargo;
        }
    }
}
