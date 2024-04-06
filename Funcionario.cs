using System;

namespace Projeto_Herança
{
    public  abstract class Funcionario : Pessoa // Apenas se Pessoa for a superclasse de Funcionario
    {
        public string Departamento { get; set; }

        // Supondo que Funcionario tem um construtor que aceita departamento
        public Funcionario(string nome, string cpf, string rg, Endereco endereco, string departamento)
            : base(nome, cpf, rg, endereco) // Chama o construtor da superclasse
        {
            this.Departamento = departamento;
        }
    }

}