﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicional2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando condicionais");

            int idade = 20;
            int quantidadePessoas = 3;

            if (idade >= 18 || quantidadePessoas > 1)
            {
                Console.WriteLine("Seja bem vindo");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("infelizmente voce nao pode entrar");
                Console.ReadLine();
            }
        }
    }
}

