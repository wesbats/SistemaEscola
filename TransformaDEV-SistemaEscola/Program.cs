using System;
using System.Collections.Generic;

namespace TransformaDEV_SistemaEscola
{
    class Program
    {
        static void Main()
        {
            // Criando uma escola
            Escola escola = new Escola();

            // Criando disciplinas
            Disciplina disciplina1 = new Disciplina("Matemática", 60, "Álgebra linear");
            Disciplina disciplina2 = new Disciplina("História", 45, "Idade Média");
            Disciplina disciplina3 = new Disciplina("Biologia", 75, "Ecologia");

            // Criando cursos
            Curso curso1 = new Curso("Licenciatura em matemática", 1001);
            Curso curso2 = new Curso("História", 2001);

            // Adicionando disciplinas aos cursos
            curso1.AdicionarDisciplina(disciplina1);
            curso2.AdicionarDisciplina(disciplina2);
            curso2.AdicionarDisciplina(disciplina3);

            // Criando alunos
            Aluno aluno1 = new Aluno("João", 20, 10001, curso1);
            Aluno aluno2 = new Aluno("Maria", 22, 10002);
            aluno1.MatricularCurso(curso2);
            aluno2.MatricularCurso(curso1);
            Aluno aluno3 = new Aluno("Pedro", 21, 10003, curso2);

            // Adicionando alunos à escola
            escola.AdicionarAluno(aluno1);
            escola.AdicionarAluno(aluno2);
            escola.AdicionarAluno(aluno3);

            // Criando um professor
            Professor professor1 = new Professor("Professor Silva", 45);
            Professor professor2 = new Professor("Professora Santos", 30);

            // Atribuindo disciplinas ao professor
            professor1.AtribuirDisciplina(disciplina1);
            professor1.AtribuirCurso(curso1);
            professor1.AtribuirDisciplina(disciplina2);
            professor1.AtribuirCurso(curso2);
            professor2.AtribuirDisciplina(disciplina3);
            professor2.AtribuirCurso(curso2);

            // Adicionando o professor à escola
            escola.AdicionarProfessor(professor1);
            escola.AdicionarProfessor(professor2);

            // Adicionando curso à escola
            escola.AdicionarCurso(curso1);
            escola.AdicionarCurso(curso2);

            // Adicionando Disciplina à escola
            escola.AdicionarDisciplina(disciplina1);
            escola.AdicionarDisciplina(disciplina2);
            escola.AdicionarDisciplina(disciplina3);

            // Apresentando informações
            Console.WriteLine("Informações da escola:");
            Console.WriteLine("---- Alunos ----");
            foreach (var aluno in escola.Alunos)
            {
                aluno.InformacoesCompletaAluno();
                Console.WriteLine();
            }

            Console.WriteLine("---- Professores ----");
            foreach (var professor in escola.Professores)
            {
                professor.ApresentarProfessor();
                Console.WriteLine();
            }

            Console.WriteLine("---- Cursos ----");
            foreach (var curso in escola.Cursos)
            {
                curso.ApresentaCurso();
            }

            Console.WriteLine("---- Disciplinas ----");
            foreach (var disciplina in escola.Disciplinas)
            {
                disciplina.ApresentarDisciplina();
            }
        }
    }
}
