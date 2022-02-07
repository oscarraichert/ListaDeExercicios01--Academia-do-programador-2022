/*Exercício 4:
• Alguns países medem temperaturas em graus Celsius, e outros em graus
Fahrenheit. Faça umalgoritmo para ler uma temperatura Celsius e imprimi-Ia em
Fahrenheit (pesquise como fazer este tipo de conversão).*/

using System;

namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite a temperatura em graus Celsius (ºC): ");
            double temperaturaC = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"A temperatura em graus Fahrenheit (ºF) é {((temperaturaC * 9) / 5) + 32}");
        }
    }
}
