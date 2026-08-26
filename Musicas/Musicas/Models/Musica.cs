using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musicas.Models
{
    public class Musica
    {
        public string Nome { get; set; }
        public Banda Artista { get; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }
        public string DescricaoMusica => 
            "A música " + Nome + " pertence a banda " + Artista;

        public Musica(Banda banda)
        {
            Artista = banda;
        }
        public void ExibirFichaTecnica()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Artista: " + Artista);
            Console.WriteLine("Duração: " + Duracao + " segundos");
            Console.WriteLine("Status: " + (Disponivel? "Disponivel" : "Indisponivel"));
            Console.WriteLine("Descição: " + DescricaoMusica);
            Console.WriteLine("\n");
        }
    }
}