using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Herança
{
    public class Aluno : Pessoa // uso de Herança
    {
        public int Matricula { get; set; }
        public Curso CursoAluno { get; set; } // uso de DELEGAÇÃO
        public Aluno()
        {
            this.Matricula = default;
            this.CursoAluno = null;
        }
        public Aluno(string nome, string cpf, string rg, Endereco endereco, int matricula, Curso
        cursoAluno) : base(nome, cpf, rg, endereco)
        {

            this.Matricula = matricula;
            this.CursoAluno = cursoAluno;

        }

        public override string RetornarDados()
        {
            return $"{Nome}, {Cpf}, {Rg}, {Matricula}, {CursoAluno}, {Logradouro}";
        }

        public override string ToString()
        {
            return $"{Nome}, {CursoAluno}";
        }
    }
}
