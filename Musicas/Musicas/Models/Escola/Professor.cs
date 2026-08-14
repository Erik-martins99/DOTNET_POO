using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musicas.Models.Escola
{
    public class Professor
    {
        public string Nome { get; set; } = string.Empty;
        public List<Disciplina> disciplinas = new List<Disciplina>();

        public Professor(string nome)
        {
            Nome = nome;
        } 

        public void AdicionaDisciplinas(Disciplina disciplina)
        {
            disciplinas.Add(disciplina);
        }

        public void ImprimeInformacoes()
        {
            Console.WriteLine("\n=================================");
            Console.WriteLine("Professor: " + Nome);
            Console.WriteLine("Disciplinas lecionadas: ");
            foreach(var disciplina in disciplinas)
            {
                disciplina.ImprimeInformacoes();
            }
            Console.WriteLine("=================================");
        }
    }
}