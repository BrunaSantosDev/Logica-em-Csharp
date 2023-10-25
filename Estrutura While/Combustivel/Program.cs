using System;
using System.Globalization;

namespace Combustivel {
    class Program {
        static void Main(string[] args) {

            //*

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Informe um código (1, 2, 3) ou 4 para parar: ");
            int x = int.Parse(Console.ReadLine(), CI);

            int a = 0;
            int g = 0;
            int d = 0;
            
            while (x != 4) {
                if (x == 1) {
                    a = a + 1;
                }
                else if (x == 2) {
                    g = g + 1;
                }
                else if (x == 3) {
                    d = d + 1;
                }

                Console.Write("Informe um código (1, 2, 3) ou 4 para parar: ");
                x = int.Parse(Console.ReadLine(), CI);
            }

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Alcool: " + a);
            Console.WriteLine("Gasolina: " + g);
            Console.WriteLine("Diesel: " + d);
        }
    }
}