using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musicas.Models.Escola
{
    public class Disciplina
    {
        public string Nome = string.Empty;
        private List<Aluno> alunos = new List<Aluno>();

        public Disciplina(string nome)
        {
            Nome = nome;
        }

        public void AdicionaAluno(Aluno aluno)
        {
            this.alunos.Add(aluno);
        }

        public void ImprimeInformacoes()
        {
            Console.WriteLine("\n-Disciplina: " + Nome);
            Console.WriteLine("\n-Alunos Matriculados: \n");
            foreach(var aluno in alunos)
            {
                Console.WriteLine("--" + aluno.Nome);
            }
        }
    }
}