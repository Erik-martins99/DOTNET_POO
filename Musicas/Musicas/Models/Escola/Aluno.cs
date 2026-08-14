using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musicas.Models.Escola
{
    public class Aluno
    {
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }
        public double[] Notas = new double[2];

        public Aluno(string nome, int idade, double[] notas)
        {
            Nome = nome;
            Idade = idade;
            Notas = notas;
        }
    }
}