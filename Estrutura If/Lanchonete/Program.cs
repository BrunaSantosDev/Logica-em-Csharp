using System;
using System.Globalization;

namespace Lanchonete {
    class Program {
        static void Main(string[] args) {
                      
            CultureInfo CI = CultureInfo.InvariantCulture;
            double cod, x, quan, va;

            Console.Write("Código do produto comprado: ");
            cod = double.Parse(Console.ReadLine(), CI);

            Console.Write("Quantidade comprada: ");
            quan = double.Parse(Console.ReadLine(), CI);

            if (cod == 1) {
                x = 5;
            }
            else if (cod == 2) {
                x = 3.5;
            }
            else if (cod == 3) {
                x = 4.8;
            }
            else if (cod == 4) {
                x = 8.9;
            }
            else {
                x = 7.32;
            }

            va = x * quan;
            Console.WriteLine("Valor a pagar: " + va.ToString("F2", CI));
        }
    }
}
