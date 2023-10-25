using System;
using System.Globalization;

namespace Retangulo {
    class Program {
        static void Main(string[] args) {

            //* O objetivo do programa é calcular a área, perímetro e diagonal de um retangulo.

            CultureInfo CI = CultureInfo.InvariantCulture;
            double b, a, area, peri, diag;

            Console.Write("Base do retangulo: ");
            b = double.Parse(Console.ReadLine(), CI);
            Console.Write("Altura do retangulo: ");
            a = double.Parse(Console.ReadLine(), CI);

            area = b * a;
            peri = 2 * (a + b);
            diag = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            Console.WriteLine("AREA = " + area.ToString("F4", CI));
            Console.WriteLine("PERIMETRO = " + peri.ToString("F4", CI));
            Console.WriteLine("DIAGONAL = " + diag.ToString("F4", CI));
        }
    }
}
