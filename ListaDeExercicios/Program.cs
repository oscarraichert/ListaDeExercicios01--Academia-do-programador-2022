/*Exercício 1:
• A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um
algoritmo para ler as dimensões de um terreno e depois exibir a área do terreno.*/

using System;

namespace ListaDeExercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Comprimento do terreno (em metros): ");
            double comprimento = Convert.ToDouble(Console.ReadLine());

            Console.Write("Largura do terreno (em metros): ");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"A área do terreno é {comprimento * largura}m²");
        }
    }
}
