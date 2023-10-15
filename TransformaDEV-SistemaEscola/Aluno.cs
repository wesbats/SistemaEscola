using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformaDEV_SistemaEscola
{
    internal class Aluno : Pessoa
    {
        public int Matricula { get; set; }
        private List<Curso> cursosMatriculados { get; } = new List<Curso>();
        public Aluno(string nome, int idade, int matricula) : base(nome, idade)
        {
            Matricula = matricula;
        }
        public Aluno(string nome, int idade, int matricula, Curso curso) : base(nome, idade)
        {
            Matricula = matricula;
            cursosMatriculados.Add(curso);
        }

        public void MatricularCurso(Curso curso)
        {
            cursosMatriculados.Add(curso);
            curso.AdicionarAluno(this);
        }

        public void InformacoesCompletaAluno()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Matrícula: {Matricula}");

            if (cursosMatriculados.Count > 0)
            {
                Console.WriteLine("Cursos matriculados");
                foreach (var curso in cursosMatriculados)
                {
                    curso.InformacoesCurso();
                }
            }
            else
            {
                Console.WriteLine("Sem cursos matriculados.");
            }
        }
    }
}