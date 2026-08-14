using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musicas.Models.Estoque
{
    public class Produto
    {
        public string Nome { get; set; } = string.Empty;
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}