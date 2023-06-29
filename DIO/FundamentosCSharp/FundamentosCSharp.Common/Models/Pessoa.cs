using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentosCSharp.Common.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public void Present()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} " +
            $"e eu tenho {Idade} anos");
        }
    }
}