using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A13_EncadeandoFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*
            //**
            //***
            //****
            //*****

            //com break
            for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
            {
                for (int contadorColunas = 0; contadorColunas < 10; contadorColunas++)
                {
                    Console.Write("*");
                    if (contadorColunas >= contadorLinhas)
                        break;

                }
                Console.WriteLine();
            }

            //sem break
            for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
            {
                for (int contadorColunas = 0; contadorColunas <= contadorLinhas; contadorColunas++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
