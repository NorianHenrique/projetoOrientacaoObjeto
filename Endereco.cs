using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Herança
{
        public class Endereco 
        {
            public string Rua { get; set; }
            public int Numero { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string Estado { get; set; }
            public string Cep { get; set; }
            public Endereco(string rua, int numero, string bairro, string cidade, string estado, string cep)
            {
                this.Rua = rua;
                this.Numero = numero;
                this.Bairro = bairro;
                this.Cidade = cidade;
                this.Estado = estado;
                this.Cep = cep;
            }

        public override string ToString()
        {
            return $"{Rua}, {Numero}, {Cidade}";
        }
    }

}



