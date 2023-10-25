using System;
using System.Globalization;

namespace Media_Ponderada {
    class Program {
        static void Main(string[] args) {

            //*

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos casos você vai digitar? ");
            int n = int.Parse(Console.ReadLine(), CI);

            double media = 0;

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Digite tres numeros: ");                
                double y = double.Parse(Console.ReadLine(), CI);
                double x = double.Parse(Console.ReadLine(), CI);
                double z = double.Parse(Console.ReadLine(), CI);

                media = ((y * 2) + (x * 3) + (z * 5)) / 10;
                Console.WriteLine("MEDIA = " + media.ToString("F1", CI));       
            }
        }
    }
}