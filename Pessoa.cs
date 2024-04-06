using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Herança
{
    public abstract class Pessoa 
    {
        public Endereco Logradouro { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public int Idade { get; set; }
      
        public object Endereco { get; internal set; }

        public abstract string RetornarDados();

        public Pessoa()
        {
            this.Nome = default;
            this.Cpf = default;
            this.Rg = default;
            this.Idade = default;
            this.Logradouro = null;
        }
        public Pessoa(string nome, string cpf, string rg, Endereco logradouro)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            this.Logradouro = logradouro; // Atribui ao campo correto
        }

        
    }
}
