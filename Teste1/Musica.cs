using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class Musica
    {
        public string Nome { get; set; }
        public string Artista { get; set; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }
        public string DescricaoResumida => $"A musica {this.Nome} pertence a banda {this.Artista}";

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {this.Nome}\nArtista: {this.Artista}\nDuração: {this.Duracao}");
            if (this.Disponivel)
            {
                Console.WriteLine("Disponivel no plano.");
            } else
            {
                Console.WriteLine("Adequira o plano PLUS+.");
            }
        }
    }
}