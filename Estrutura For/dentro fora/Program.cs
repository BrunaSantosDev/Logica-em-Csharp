using System;
using System.ComponentModel;
using System.Globalization;

namespace Dentro_Fora {
    class Program {
        static void Main(string[] args) {

            //*

            Console.Write("Quantos numeros voce vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            int dentro = 0;
            int fora = 0;

            for (int i =0; i < n; i++) {
                Console.Write("Digite um número: ");
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20) {
                    dentro = dentro + 1;
                }
                else {
                    fora = fora + 1;
                }
            }

            Console.WriteLine(dentro + " DENTRO");
            Console.WriteLine(fora + " FORA");
        }
    }
}