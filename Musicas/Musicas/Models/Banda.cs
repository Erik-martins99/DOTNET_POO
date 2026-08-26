using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musicas.Models
{
    public class Banda
    {
        private List<Album> albuns = new List<Album>();
        public string Nome { get; set; }

        public Banda(string nome)
        {
            Nome = nome;
        }
        public void AdicionarAlbum(Album albun)
        {
            albuns.Add(albun);
        }

        public void ExibirDiscografia()
        {
            Console.WriteLine("Discografia da Banda " + Nome);
            foreach(var album in albuns)
            {
                Console.WriteLine($"Album: {album.Nome} ({album.DuracaoTotal} segundos)");
            }
        }
    }
}