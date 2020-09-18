using System;

namespace GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {
            double Celsius;
            double Fahrenheit = 32;

            Console.Write("Digite seu Valor em Celsius: ");
            Celsius = double.Parse(Console.ReadLine());

            Fahrenheit = Celsius * 1.8 + 32;
            Console.WriteLine("Celsius para Fahrenheit = {0}", Fahrenheit);
            Console.Write("\n");

            Console.WriteLine("Pressione ENTER para sair!");
            Console.ReadKey();
        }
    }
}
