using System;
using System.Globalization;

namespace Par_Impar {
    class Program {
        static void Main(string[] args) {

            //*

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos números você vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.Write("Digite um número: ");
                int x = int.Parse(Console.ReadLine());

                if (x % 2 != 0 && x < 0) {
                    Console.WriteLine("IMPAR NEGATIVO");
                }
                else if (x % 2 == 0 && x < 0) {
                    Console.WriteLine("PAR NEGATIVO");
                }
                else if (x % 2 != 0 && x > 0) {
                    Console.WriteLine("IMPAR POSITIVO");
                }
                else if (x % 2 == 0 && x > 0) {
                    Console.WriteLine("PAR POSITIVO");
                }
                else if (x == 0) {
                    Console.WriteLine("NULO");
                }
            }
        }
    }
}