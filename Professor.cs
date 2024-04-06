using System;

namespace Projeto_Herança
{
    public class Professor : Funcionario
    {
        private string v;

        public string Titulacao { get; set; }
        public string Area { get; set; }

        public Professor(string nome, string cpf, string rg, Endereco endereco, string titulacao, string area, string departamento)
            : base(nome, cpf, rg, endereco, departamento)
        {
            this.Titulacao = titulacao;
            this.Area = area;
        }

        public Professor(string nome, string cpf, string rg, Endereco endereco, string departamento, string v) : base(nome, cpf, rg, endereco, departamento)
        {
            this.v = v;
        }

        public override string RetornarDados()
        {
            return $"{Nome}, {Cpf}, {Rg}, {Titulacao}, {Area}, {Logradouro}";
        }

        public override string ToString()
        {
            return $"{Nome}, {Titulacao}, {Logradouro}";
        }
    }
}