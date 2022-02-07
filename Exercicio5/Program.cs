/*Exercício 5:
• Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%.
Após o aumento,desconte 8% de impostos. Imprima o salário inicial, o salário
com o aumento e o salário final. */

using System;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite seu salário: R$");
            double salario = Convert.ToDouble(Console.ReadLine());

            double salario_com_aumento = salario + (salario * 0.15);
            double salario_com_imposto = salario_com_aumento - (salario_com_aumento * 0.08);

            Console.WriteLine($"\nSalário inicial: R${salario}");
            Console.WriteLine($"Salário com aumento: R${salario_com_aumento}");
            Console.WriteLine($"Salário após imposto: R${salario_com_imposto}");
        }
    }
}