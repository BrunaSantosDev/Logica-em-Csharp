using System;
using System.Globalization;

namespace Coordenadas {
    class Program {
        static void Main(string[] args) {

            //* Ler e determinar qual quadrante se encaixa

            CultureInfo CI = CultureInfo.InvariantCulture;
            double x, y;

            Console.Write("Valor de X: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor de Y: ");
            y = double.Parse(Console.ReadLine());

            if (x == 0 && y == 0) {
                Console.WriteLine("Origem");
            }
            else if (x == 0) {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0) {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0 && y > 0) {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0) {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0) {
                Console.WriteLine("Q3");
            }
            else {
                Console.WriteLine("Q4");
            }
        }
    }
}