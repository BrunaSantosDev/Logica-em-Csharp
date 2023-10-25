using System;
using System.Globalization;

namespace Medidas {
    class Program {
        static void Main(string[] args) {

            //* O programa calcula a área de um quadrado, triangulo e trapezio a partir de 3 medidas.

            CultureInfo CI = CultureInfo.InvariantCulture;
            double a, b, c, at, aq, att;

            Console.Write("Digite a medida A: ");
            a = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a medida B: ");
            b = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a medida C: ");
            c = double.Parse(Console.ReadLine(), CI);

            aq = a * a;
            at = (b * a) / 2;
            att = ((a + b) * c) / 2;

            Console.WriteLine("AREA DO QUADRADO = " + aq.ToString("F4", CI));
            Console.WriteLine("AREA DO TRIANGULO = " + at.ToString("F4", CI));
            Console.WriteLine("AREA DO TRAPEZIO = " + att.ToString("F4", CI));
        }
    }
}