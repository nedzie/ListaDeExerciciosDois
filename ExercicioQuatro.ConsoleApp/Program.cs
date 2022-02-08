using System;

namespace ExercicioQuatro.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variáveis
            int numero;
            string res;

            // Entradas
            Console.WriteLine("Digite um número inteiro qualquer:"); // Apenas números inteiros podem ser considerados ímpar/par!
            numero = int.Parse(Console.ReadLine());

            // Processamento
            if(numero % 2 == 0)
            {
                res = " é par";
            } else
            {
                res = " é ímpar";
            }

            // Saídas
            Console.Clear();
            Console.WriteLine(numero + res);
        }
    }
}