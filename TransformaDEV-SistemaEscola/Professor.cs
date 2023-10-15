using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformaDEV_SistemaEscola
{
    internal class Professor : Pessoa
    {
        public List<Disciplina> DisciplinasLecionadas { get; } = new List<Disciplina>();
        public List<Curso> CursosLecionados { get; } = new List<Curso>();

        public Professor(string nome, int idade) : base(nome, idade)
        {
        }

        public void AtribuirDisciplina(Disciplina disciplina)
        {
            DisciplinasLecionadas.Add(disciplina);
            disciplina.AdicionarProfessor(this);
        }

        public void AtribuirCurso(Curso curso)
        {
            CursosLecionados.Add(curso);
        }

        public void ListarDisciplinas()
        {
            if (DisciplinasLecionadas.Count > 0)
            {
                Console.WriteLine("Disciplinas Lecionadas");
                foreach (var disciplina in DisciplinasLecionadas)
                {
                    disciplina.InformacoesDisciplina();
                }
            }
            else
            {
                Console.WriteLine("Não está lecionando disciplinas no momento.");
            }
        }

        public void ListarCursos()
        {
            if (CursosLecionados.Count > 0)
            {
                Console.WriteLine("Cursos Lecionados:");
                foreach (var curso in CursosLecionados)
                {
                    curso.InformacoesCurso();
                }
            }
            else
            {
                Console.WriteLine("Não está lecionando cursos no momento.");
            }
        }
        public void ApresentarProfessor()
        {
            ApresentaPessoa();
            ListarCursos();
            ListarDisciplinas();
        }
    }
}