using System;
using System.Globalization;

namespace Glicose {
    class Program {
        static void Main(string[] args) {

            //* O programa lê a quantidade de glicose no sangue e a sua classificação perante a diabetes.

            CultureInfo CI = CultureInfo.InvariantCulture;
            string classi;

            Console.Write("Digite a medida da glicose: ");
            double gli = double.Parse(Console.ReadLine());

            if (gli < 100) {
                classi = "normal";
            }
            else if (gli > 100 && gli <= 140) {
                classi = "elevado";
            }
            else {
                classi = "diabetes";
            }

            Console.WriteLine("Classificação: " + classi);
        }
    }
}