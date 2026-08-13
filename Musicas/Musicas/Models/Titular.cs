using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace Musicas.Models
{
    public class Titular
    {
        private string Nome { get; set; }
        private string Email { get; set; }

        public Titular(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
        public string DadosDoTitular()
        {
            return Nome + " - " + Email;
        }
    }
}