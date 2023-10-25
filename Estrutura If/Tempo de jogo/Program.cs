using System;
using System.Globalization;

namespace Tempo_De_Jogo {
    class Program {
        static void Main(string[] args) {

            //*

            CultureInfo CI = CultureInfo.InvariantCulture;
            double i, f, du;

            Console.Write("Hora inicial: ");
            i = double.Parse(Console.ReadLine());

            Console.Write("Hora final: ");
            f = double.Parse(Console.ReadLine());

            if (i < f) {
                du = f - i;
            }
            else {
                du = 24 - i + f;
            }

            Console.WriteLine("O jogo durou " + du + " hora (s).");
        }
    }
}
