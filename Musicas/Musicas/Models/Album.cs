using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musicas.Models
{
    public class Album
    {
        public string Nome { get; set; }
        private int duracaoTotal { get; set; }
        private List<Musica> musicas = new List<Musica>();


        public void AdicionaMusica(Musica musica)
        {
            musicas.Add(musica);
            AdicionaDuracao(musica.Duracao);
        }

        private void AdicionaDuracao(int duracao)
        {
            duracaoTotal += duracao;
        }

        public void ImprimeAlbum()
        {
            Console.WriteLine("===========================");
            Console.WriteLine("Album: " + Nome);
            Console.WriteLine("Duração total: " + duracaoTotal + " segundos");
            Console.WriteLine("\nMusicas: ");

            foreach(var musica in musicas)
            {
                Console.WriteLine(" - " + musica.Nome + " : " + musica.DescricaoMusica);
            }
            
            Console.WriteLine("===========================");
        }
    }
}