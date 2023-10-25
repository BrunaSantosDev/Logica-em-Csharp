using System;
using System.Globalization;

namespace Tabuada {
    class Program {
        static void Main(string[] args) {

            //*

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Deseja a tabuada para qual valor? ");
            int x = int.Parse(Console.ReadLine(), CI);

            // Tradução: Para (variável i q é igual a 0; enquanto i for menor que o número na variável x; faça de 1 em 1).
            for (int i = 1; i < 11; i++) {
                int tabuada = x * i;
                Console.WriteLine(x + " x " + i + " = " + tabuada);
            }
        }
    }
}