using System;
using System.Globalization;

namespace Idades {
    class Progeram {
        static void Main(string[] args) {

            //* O objetivo do programa é calcular a média entre 2 idades de 2 pessoas diferentes.

            CultureInfo CI = CultureInfo.InvariantCulture;
            string p1, p2;
            double media, i1, i2;            

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1 = Console.ReadLine();
            Console.Write("Idade: ");
            i1 = double.Parse(Console.ReadLine(), CI);

            Console.Write("Nome: ");
            p2 = Console.ReadLine();
            Console.Write("Idade: ");
            i2 = double.Parse(Console.ReadLine(), CI);

            media = (i1 + i2) / 2;

            Console.WriteLine("A idade media de " + p1 + " e " + p2 + " é de " + media.ToString("F1", CI) + " anos.");

        }
    }
}
