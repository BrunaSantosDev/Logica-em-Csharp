using System;
using System.Globalization;

namespace Quadrante {
    class Program {
        static void Main(string[] args) {

            //*

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite os valores das coordenadas X e Y:");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            while (x != 0 || y != 0) {
                if (x > 0 && y > 0) {
                  Console.WriteLine("Quadrante 1");
                }
                else if (x < 0 && y > 0) {
                  Console.WriteLine("Quadrante 2");
                }
                else if (x < 0 && y < 0) {
                  Console.WriteLine("Quadrante 3");
                }
                else {
                  Console.WriteLine("Quadrante 4");
                }
            
                Console.WriteLine("Digite os valores das coordenadas X e Y:");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }                                                 
        }
    }
}