using System;
using System;
using System.Globalization;

namespace Divisão {
    class Program {
        static void Main(string[] args) {

            //*
            CultureInfo CI = CultureInfo.InvariantCulture;
            double divisao;

            Console.Write("Quantos casos você vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.Write("Entre com o numerador: ");
                double x = double.Parse(Console.ReadLine(), CI);
                Console.Write("Entre com o denominador: ");
                double y = double.Parse(Console.ReadLine(), CI);

                if (y == 0) {
                    Console.WriteLine("DIVISÃO IMPOSSIVEL");
                }                
                else {
                    divisao = (x / (y));
                    Console.WriteLine("DIVISAO = " + divisao.ToString("F2", CI));
                }                
            }
        }
    }
} 