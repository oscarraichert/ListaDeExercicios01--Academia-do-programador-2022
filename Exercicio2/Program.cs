/*Exercício 2:
• A padaria Hotpão vende uma certa quantidade de pães franceses e uma
quantidade de broas acada dia. Cada pãozinho custa R$ 0,12 e a broa custa R$
1,50. Ao final do dia, o dono quer saberquanto arrecadou com a venda dos pães
e broas (juntos), e quanto deve guardar numa conta depoupança (10% do total
arrecadado). Você foi contratado para fazer os cálculos para o dono. Combase
nestes fatos, faça um algoritmo para ler as quantidades de pães e de broas, e
depois calcularos dados solicitados. */

using System;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número de pães franceses vendidos: ");
            double franceses = Convert.ToDouble(Console.ReadLine());

            Console.Write("Número de broas vendidas: ");
            double broas = Convert.ToDouble(Console.ReadLine());

            double valorFranceses = franceses * 0.12;
            double valorBroas = broas * 1.50;

            double valorTotal = valorFranceses + valorBroas;
            double poupança = valorTotal * 0.10;

            Console.WriteLine($"O valor total das vendas foi: R${valorTotal}.");
            Console.WriteLine($"O valor das vendas com o desconto para a poupança é: R${valorTotal - poupança}");
            Console.WriteLine($"O valor guardado na poupança é: R${poupança}");
        }
    }
}
