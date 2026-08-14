using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Musicas.Models.Estoque
{
    public class Estoque
    {
        private List<Produto> produtos = new List<Produto>();

        public void AdcionarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        public void ImprimirEstoque()
        {
            Console.WriteLine("Itens do Estoque: \n");

            for(int i=0; i < produtos.Count; i++)
            {
                Console.WriteLine("- " + produtos[i].Nome);
            }
        }
    }
}