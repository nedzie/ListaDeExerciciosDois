using System;

namespace ExercicioTres.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variáveis

            double peso, altura, imc;
            string resImc;

            // Entradas

            Console.WriteLine("-~= IMC Calculator 6000 =~-\nPor favor, informe seu peso (Separado por ','):");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor, digite sua altura (Separado por ','):");
            altura = double.Parse(Console.ReadLine());

            // Processamento
            imc = peso / (altura * altura);
            if(imc < 18.5)
            {
                resImc = "Você está abaixo do peso.";
            } else if(imc >= 18.5 && imc <= 25)
            {
                resImc = "Você está com peso normal.";
            } else if(imc > 25 && imc <= 30)
            {
                resImc = "Você está acima do peso.";
            }
            else
            {
                resImc = "Você está obeso.";
            }

            // Saídas
            Console.Clear();
            Console.WriteLine($"Seu resultado do IMC:\nSeu IMC: {imc:F2} - {resImc}"); //Outra maneira de fazer com que mostre apenas 2 digitos após o ponto
        }   
    }
}