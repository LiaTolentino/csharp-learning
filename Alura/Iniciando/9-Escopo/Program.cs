﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 20;
            int quantidadePessoas = 3;
            bool acompanhado;
            if (quantidadePessoas >= 2)
            {
                acompanhado = true;
            }
            else
            {
                acompanhado = false;
            }
            if (idade >= 18 || acompanhado)
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
