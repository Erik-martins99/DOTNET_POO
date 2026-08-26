using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste1.Models.Movie
{
    public class Artista
    {
        private string nome;
        private int idade;
        private List<Movie> filmes;

        public Artista(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
            filmes = new List<Movie>();
        }

        public void adicionaFilme(Movie filme)
        {
            filmes.Add(filme);
        }

        public string getNome()
        {
            return nome;
        }

        public void fichaTecnica()
        {
            Console.WriteLine($"\nNome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine("Filmes: ");
            foreach(var filme in filmes)
            {
                Console.WriteLine($"- {filme.getTitulo()}");
            }
        }
    }
}