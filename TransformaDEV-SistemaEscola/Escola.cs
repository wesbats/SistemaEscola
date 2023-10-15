using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformaDEV_SistemaEscola
{
    internal class Escola
    {
        public List<Aluno> Alunos { get; private set; } = new List<Aluno>();
        public List<Curso> Cursos { get; private set; } = new List<Curso>();
        public List<Disciplina> Disciplinas { get; private set; } = new List<Disciplina>();
        public List<Professor> Professores { get; private set; } = new List<Professor>();

        public void AdicionarAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
        }

        public void AdicionarCurso(Curso curso)
        {
            Cursos.Add(curso);
        }

        public void AdicionarDisciplina(Disciplina disciplina)
        {
            Disciplinas.Add(disciplina);
        }

        public void AdicionarProfessor(Professor professor)
        {
            Professores.Add(professor);
        }
    }
}
