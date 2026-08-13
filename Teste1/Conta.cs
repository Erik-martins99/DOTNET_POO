using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class Carro
    {
            public string Modelo { get; set; }
            public string Fabricante { get; set; }
            public int _ano;
            public int Ano { 
                get => this._ano; 
                set
                {
                    if (value < 2023 && value > 1960) 
                    {
                        this._ano = value;
                    } else
                    {
                        Console.WriteLine("Ano invalido!");
                    }
                }   
            }

            public string DescricaoDetalhada => $"Modelo: {this.Fabricante} - {Modelo} {Ano}";
    }
}