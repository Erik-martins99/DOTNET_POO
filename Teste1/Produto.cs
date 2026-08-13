using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public float preco;
        public float Preco 
        { 
            get => preco;
            set
            {
                if (value > 0)
                {
                    preco = value;
                } else
                {
                    Console.WriteLine("Preço invalido!");
                }
            } 
        }
        public float estoque;
        public float Estoque 
        { 
            get => estoque;
            set
            {
                if (value > 0)
                {
                    estoque = value;
                } else
                {
                    Console.WriteLine("Estoque invalido!");
                }
            } 
        }
        public string InformacoesDetalhadas { get => $"{Marca} {Nome} \nPrice: {Preco} \nEstoque: {Estoque}"; }

    }
}