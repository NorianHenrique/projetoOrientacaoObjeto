using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Herança
{
 
       public class Curso
        {
            public string Nome { get; set; }
            public string Descricao { get; set; }
            public int CargaHoraria { get; set; }
            public Curso(string nome, string descricao, int cargaHoraria)
            {
                this.Nome = nome;
                this.Descricao = descricao;
                this.CargaHoraria = cargaHoraria;
            }

            public override string ToString()
            {
                return $"{Nome}";
            }

    }
    }


