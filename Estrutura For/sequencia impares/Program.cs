using System;
using System.Globalization;

namespace Sequencia_Impares {
    class Program {
        static void Main(string[] args) {

            //*

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite o valor de X: ");
            int x = int.Parse(Console.ReadLine(), CI);

            // para (varíavel i; enquanto i for menor/igual que x; passe de 1 em 1)
            for (int i = 1; i <= x; i++) {
                // se (o resto da divisão de i por 2 for diferente de 0, faça)
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }                
            }
        }
    }
}