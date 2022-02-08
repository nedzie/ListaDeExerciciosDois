using System;

namespace ExercicioUm.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada de valores

            Console.WriteLine("Bem-vindo(a).\nInsira o número A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora o número B: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora o número C: ");
            int c = int.Parse(Console.ReadLine());

            // Processamento

            Console.Clear();
            int soma = a + b;
            string resultado = "";

            if(soma == c)
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                resultado = "A soma de [a] " + a + " e [b] " + b + " [=" + soma + "] " + "é igual a [c] " + c;
            } else if(soma < c)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                resultado = "A soma de [a] " + a + " e [b] " + b + " [=" + soma + "] " + "é menor que [c] " + c;
            } else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                resultado = "A soma de [a] " + a + " e [b] " + b + " [=" + soma + "] " + "é maior que [c] " + c;

            }

            // Saídas
            Console.WriteLine(resultado);
            Console.ResetColor();
        }
    }
}