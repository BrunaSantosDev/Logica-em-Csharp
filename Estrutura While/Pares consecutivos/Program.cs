using System;
using System.Globalization;

namespace Pares_Consecutivos {
    class Program {
        static void Main(string[] args) {

            //*
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite um númeroi inteiro: ");
            double x = double.Parse(Console.ReadLine(), CI);

            while (x != 0) {
                if (x % 2 != 0) {
                    x = x + 1;
                }
                double soma = 5 * x + 20;
                Console.WriteLine("SOMA = " + soma);

                Console.Write("Digite um númeroi inteiro: ");
                x = double.Parse(Console.ReadLine(), CI);
            }
        }
    }
}