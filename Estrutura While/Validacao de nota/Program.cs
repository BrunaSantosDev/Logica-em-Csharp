using System;
using System.Globalization;
using System.Xml;

namespace Validacao_de_nota {
    class Program {
        static void Main(string[] args) {

            //*

            CultureInfo CI = CultureInfo.InvariantCulture;
            double x, y, media;

            Console.Write("Digite a primeira nota: ");
            x = double.Parse(Console.ReadLine(), CI); 

            while (x < 0 || x > 10) {
                Console.Write("Valor invalido! Tente novamente: ");
                x = double.Parse(Console.ReadLine(), CI);                
            }

            Console.Write("Digite a segunda nota: ");
            y = double.Parse(Console.ReadLine(), CI);

            while (y < 0 || y > 10) {
                Console.Write("Valor invalido! Tente novamente: ");
                y = double.Parse(Console.ReadLine(), CI);
            }

            media = ((x + y) / 2);

            Console.WriteLine("MÉDIA = " + media.ToString("F2", CI));
        }
    }
}