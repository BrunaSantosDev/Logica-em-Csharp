using System;
using System.Globalization;

namespace Fatorial {
    class Program {
        static void Main(string[] args) {

            //*

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite o valor de N: ");
            int n = int.Parse(Console.ReadLine());

            double fatorial;
            fatorial = 1;

            //para (variavel i igual a n; de i até 0; faça de 1-1)
            for (int i = n; i > 0; i--) {
                fatorial = fatorial * i;
            }

            Console.WriteLine("FATORIAL = " + fatorial);
        }
    }
}