using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musicas.Models
{
    public class Conta
    {
        private Titular titular;
        private string Agencia { get; set; } 
        private string Numero { get; set;}
        private decimal saldo { get; set; }
        private decimal limite { get; set; }

        public void AbrirConta(
            Titular titular,
            string agencia,
            string numero,
            decimal saldo,
            decimal limite
            )
        {
            this.titular = titular;
            this.Agencia = agencia;
            this.Numero = numero;
            this.saldo = saldo;
            this.limite = limite;
        }

        public void DadosDaConta()
        {
            Console.WriteLine(titular.DadosDoTitular());
            Console.WriteLine("Conta: " + Numero + ", Ag. " + Agencia);
            Console.WriteLine("Saldo: " + saldo);
            Console.WriteLine("Limite: " + limite);
        }
    }
}