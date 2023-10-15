using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformaDEV_SistemaEscola
{
    internal class Disciplina
    {
        public string Titulo { get; private set; }
        public int CargaHoraria { get; private set; }
        public string Ementa { get; private set; }
        public Professor Professor { get; private set; }

        public Disciplina(string titulo, int cargaHoraria, string ementa)
        {
            Titulo = titulo;
            CargaHoraria = cargaHoraria;
            Ementa = ementa;
        }

        public void AdicionarProfessor(Professor professor)
        {
            Professor = professor;
        }

        public void InformacoesDisciplina()
        {
            Console.WriteLine($"- Disciplina: {Titulo}");
            Console.WriteLine($"  Carga horária: {CargaHoraria} horas");
            Console.WriteLine($"  Ementa: {Ementa}");
        }
        public void ApresentarDisciplina()
        {
            InformacoesDisciplina();
            Console.WriteLine($"  Professor: {(Professor != null ? Professor.Nome : "Sem professor no momento")}");
            Console.WriteLine();
        }
    }
}