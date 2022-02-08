using System;

namespace ExercicioCinco.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variáveis

            int a, b, x;
            string res;

            // Entradas

            Console.WriteLine("Digite o número a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número b:");
            b = int.Parse(Console.ReadLine());

            // Processamento

            if(a == b)
            {
                x = a + b;
                res = "Como A e B são iguais, o resultado é: " + a + " + " + b + " = " + x;
            } else
            {
                x = a * b;
                res = "Como A e B são diferentes, o resultado é: " + a + " x " + b + " = " + x;
            }

            // Saídas
            Console.WriteLine(res);
        }
    }
}