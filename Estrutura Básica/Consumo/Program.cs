using System;
using System.Globalization;

namespace Consumo {
    class Program {
        static void Main(string[] args) {

            //* O programa mostra o consumo de combustível por km do carro.

            CultureInfo CI = CultureInfo.InvariantCulture;
            double di, cg, cm;

            Console.Write("Distancia percorrida: ");
            di = double.Parse(Console.ReadLine(), CI);
            Console.Write("Combustivel gasto: ");
            cg = double.Parse(Console.ReadLine(), CI);

            cm = di / cg;

            Console.WriteLine("Consumo médio = " + cm.ToString("F3", CI));

        }
    }
}