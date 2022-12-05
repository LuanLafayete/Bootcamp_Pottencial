using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorar.Models
{
    public class Curso
    {
        //Atributos
        public string NomeDoCurso { get; set; }
        public List<Pessoa> AlunosDoCurso { get; set; }

        //Métodos
        public void AdicionarAluno(Pessoa aluno)
        {
            AlunosDoCurso.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = AlunosDoCurso.Count;
            return quantidade;
        }

        public void RemoverAluno(Pessoa aluno)
        {
            AlunosDoCurso.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {NomeDoCurso}");

            for (int count = 0; count < AlunosDoCurso.Count; count++)
            {
                //string texto = "Nº " + count + " - " + AlunosDoCurso[count].NomeCompleto;
                string texto = $"Nº {count + 1} - {AlunosDoCurso[count].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }        
    }
}