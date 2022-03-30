﻿using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome?");
            String nome = Console.ReadLine();

            Console.WriteLine("Qual sua altura em metros? Ex.: 1,65");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Qual seu peso em Kg? Ex.: 65,5");
            float peso = Convert.ToSingle(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("{0}, sua altura é: {1} e seu peso é: {2}", nome, altura, peso);

            Console.WriteLine("Seu IMC é {0}", imc);
        }
    }
}
