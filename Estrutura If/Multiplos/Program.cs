using System;
using System.Globalization;

namespace Multiplos {
    class Program {
        static void Main(string[] args) {

            //*
            CultureInfo CI = CultureInfo.InvariantCulture;
            int x, y;

            Console.WriteLine("Digite dois numeros inteiros:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x % y == 0 || y % x == 0) {
                Console.WriteLine("São multiplos");
            } 
            else {
                Console.WriteLine("Não são multiplos");
            }
        }
    }
}