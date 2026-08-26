using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Teste1.Models.Movie
{
    public class Movie
    {
        private string titulo;
        private int duracao;
        private List<Artista> elenco = new List<Artista>();

        public Movie(string titulo, int duracao)
        {
            this.titulo = titulo;
            this.duracao = duracao;
        }

        public void adicionarArtista(Artista artista)
        {
            elenco.Add(artista);
            artista.adicionaFilme(this);
        }

        public string getTitulo()
        {
            return titulo;
        }

        public void fichaTecnica()
        {
            Console.WriteLine($"\nTitulo: {titulo}");
            Console.WriteLine($"Duracao: {duracao}");
            Console.WriteLine("Elenco: ");
            foreach(var artisra in elenco)
            {
                Console.WriteLine($"- {artisra.getNome()}");
            }
        }

    }
}