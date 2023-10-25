using System;
using System.Globalization;

namespace Soma_Impares {
    class Program {
        static void Main(string[] args) {

            //*

            CultureInfo CI = CultureInfo.InvariantCulture;
            Console.WriteLine("Digite dois números:");
            int x = int.Parse(Console.ReadLine(), CI);
            int y = int.Parse(Console.ReadLine(), CI);

            if (x > y) {
                int troca = x;
                x = y;
                y = troca;
            }

            int soma = 0;

            for (int i = x + 1; i < y; i++) {
                if (i % 2 != 0) {
                    soma = soma + i;
                }
            }

            Console.WriteLine("SOMA DOS IMPARES = " + soma);
        }
    }
}