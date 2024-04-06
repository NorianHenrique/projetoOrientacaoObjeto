using System;

namespace Projeto_Herança
{
    public class Coordenador : Funcionario
    {
        public string CursoCoordenado { get; set; }
        public int AnosExperiencia { get; set; }
        public decimal Salario { get; set; }

        public Coordenador(string nome, string cpf, string rg, Endereco endereco, string departamento, string cursoCoordenado, int anosExperiencia, decimal salario)
            : base(nome, cpf, rg, endereco, departamento)
        {
            this.CursoCoordenado = cursoCoordenado;
            this.AnosExperiencia = anosExperiencia;
            this.Salario = salario;
        }

        public override string RetornarDados()
        {
            return $"{Nome}, {Cpf}, {Rg}, {Salario},{Logradouro}";
        }

        public override string ToString()
        {
            return $"{Nome}, {Logradouro}";
        }
    }
}