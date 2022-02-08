using System;

namespace ExercicioDois.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variáveis 

            double a, b, c;

            // Entradas
            Console.WriteLine("Para números com casas decimais, utilize ',' (Vírgula) para separar.");
            Console.WriteLine("Digite o primeiro valor: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro valor: ");
            c = double.Parse(Console.ReadLine());

            // Processamento
            if(a<b) // Se 1. for menor que 2., inverte para deixar decrescente (X, x, ?)
            {
                (a, b) = (b, a); // Swap de variáveis sem usar uma temporária
            }
            if(a<c) // Se 1. for menor que 3., inverte para deixar decrescente (X, ?, x)
            {
                (a, c) = (c, a);
            }
            if(b<c) // Se 2. for menor que 3., inverte para deixar decrescente (^X, X, x)
            {
                (b, c) = (c, b);
            }
            Console.Clear();
            Console.WriteLine("Ordenados de maneira decrescente:\n1. " + a + "\n2. " + b + "\n3. " + c); 
        }
    }
}