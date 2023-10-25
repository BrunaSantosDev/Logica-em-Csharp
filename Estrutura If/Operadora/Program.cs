using System;
using System.Globalization;

namespace Operadora {
    class Program {
        static void Main(string[] args) {

            //*
            CultureInfo CI = CultureInfo.InvariantCulture;
            int m, v;

            Console.Write("Digite a quantidade de minutos: ");
            m = int.Parse(Console.ReadLine(), CI);

            v = 50;
            if (m > 100) {
                v += 2 * (m - 100);
            }

            Console.WriteLine("Valor a pagar: R$ " + v.ToString("F2", CI));
        }
    }
}
