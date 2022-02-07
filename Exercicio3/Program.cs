/*Exercício 3:
• Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir
quantos dias de vidaela possui. Considere sempre anos completos, e que um
ano possui 365 dias. Ex: uma pessoa com 19 anos possui 6935 dias de vida; veja
um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.*/

using System;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva seu nome: ");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Informe quantos anos você tem: ");
            int anos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{nome}, você viveu {anos*365} dias.");
        }
    }
}
