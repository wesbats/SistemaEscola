using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformaDEV_SistemaEscola
{
    internal class Curso
    {
        public string Nome { get; private set; }
        public int CodigoCurso { get; private set; }
        private List<Aluno> AlunosMatriculados { get; } = new List<Aluno>();
        private List<Disciplina> Disciplinas { get; } = new List<Disciplina>();

        public Curso(string nome, int codigoCurso)
        {
            Nome = nome;
            CodigoCurso = codigoCurso;
        }

        public void AdicionarAluno(Aluno aluno)
        {
            AlunosMatriculados.Add(aluno);
        }

        public void AdicionarDisciplina(Disciplina disciplina)
        {
            Disciplinas.Add(disciplina);
        }

        public void ListarAlunos()
        {
            if (AlunosMatriculados.Count > 0)
            {
                Console.WriteLine("Alunos matriculados:");
                foreach (var aluno in AlunosMatriculados)
                {
                    aluno.ApresentaPessoa();
                }
            }
            else
            {
                Console.WriteLine("Sem alunos matriculados no momento.");
            }
        }

        public void ListarDisciplinas()
        {
            if (Disciplinas.Count > 0)
            {
                Console.WriteLine("Disciplinas no curso:");
                foreach (var disciplina in Disciplinas)
                {
                    disciplina.InformacoesDisciplina();
                }
            }
            else
            {
                Console.WriteLine("Sem disciplinas no curso no momento.");
            }
        }
        public void InformacoesCurso()
        {
            Console.WriteLine($"- Formação: {Nome}, Código: {CodigoCurso}");
        }

        public void ApresentaCurso()
        {
            InformacoesCurso();
            ListarAlunos();
            ListarDisciplinas();
            Console.WriteLine();
        }
    }
}
