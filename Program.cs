using Projeto_Herança;
using System;
using System.Collections.Generic;
// Norian Henrique
namespace Projeto_Herança
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Curso curso = new Curso("Curso 1", "Descrição 1", 100);
            Aluno x = new Aluno("Abc", "123", "456", new Endereco("Rua 1", 12, "Bairro 1", "Cidade 1", "Estado 1", "12345-678"), 123, curso);
            Aluno y = new Aluno("Def", "789", "101", new Endereco("Rua 2", 43, "Bairro 2", "Cidade 2", "Estado 2", "12345-678"), 456, curso);
            Aluno z = new Aluno("Ghi", "101", "112", new Endereco("Rua 5", 78, "Bairro 5", "Cidade 5", "Estado 5", "54321-876"), 789, curso);
            Endereco auxEnd = new Endereco("Rua 3", 45, "Bairro 3", "Cidade 3", "Estado 3", "12345-678");
            Professor professor1 = new Professor("Xyz", "123", "456", auxEnd, "Doutor", "Computação");
            Professor professor2 = new Professor("Wxy", "789", "101", new Endereco("Rua 4", 245, "Bairro 4", "Cidade 4", "Estado 4", "12345-879"), "Mestre", "Matemática");
            Coordenador coordenador1 = new Coordenador("Dr. Smith", "123", "456", auxEnd, "TI", "Sistemas de Informação", 10, 5000);

            // Adicionar alunos, professores e coordenadores em um list do tipo Pessoa
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(x);
            pessoas.Add(y);
            pessoas.Add(z);
            pessoas.Add(professor1);
            pessoas.Add(professor2);
            pessoas.Add(coordenador1);

            // Listagem dos dados cadastrados
            foreach (var item in pessoas)
            {
                //Console.WriteLine($"{item.GetType().Name} => Nome: {item.Nome}, CPF: {item.Cpf}, RG: {item.Rg}, Endereço: {item.Logradouro.Rua}, {item.Logradouro.Numero}, {item.Logradouro.Bairro}, {item.Logradouro.Cidade}, {item.Logradouro.Estado}, {item.Logradouro.Cep}");
                //Console.WriteLine($"{item.RetornaDados()}");
                 Console.WriteLine($"{item.GetType().Name} => {item}");

                if (item is Aluno a)
                {
                    //Console.WriteLine($"Matrícula: {a.Matricula}, Curso: {a.CursoAluno.Nome}\n");
                    //Console.WriteLine($"{a.RetornaDados()}");
                    Console.WriteLine($"{item.GetType().Name} => {a}");
                }
                else if (item is Professor p)
                {
                    //Console.WriteLine($"Departamento: {p.Departamento}, Titulação: {p.Titulacao}, Área: {p.Area}\n");
                    //Console.WriteLine($"{p.RetornaDados()}");
                    Console.WriteLine($"{item.GetType().Name} => {p}");
                }
                else if (item is Coordenador c)
                {
                    //Console.WriteLine($"Departamento: {c.Departamento}, Curso Coordenado: {c.CursoCoordenado}, Anos de Experiência: {c.AnosExperiencia}, Salário: {c.Salario}\n");
                    //Console.WriteLine($"{c.RetornaDados()}");
                     Console.WriteLine($"{item.GetType().Name} => {c}");
                }
            }
        }
    }
}

