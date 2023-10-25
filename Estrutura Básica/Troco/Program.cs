using System;
using System.Globalization;

namespace Troco {
    class Program {
        static void Main(string[] args) {

            //* O objetivo do programa é calcular o troco da compra de um produto.

            CultureInfo CI = CultureInfo.InvariantCulture;
            double p, q, v, troco;

            Console.Write("Preço unitário do produto: ");
            p = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade comprada: ");
            q = double.Parse(Console.ReadLine(), CI);
            Console.Write("Dinheiro recebido: ");
            v = double.Parse(Console.ReadLine(), CI);

            if ((p * q) < q) {
                troco = (p * q) - v;
            }
            else {
                troco = v - (p * q); 
            }

            Console.WriteLine("TROCO = " + troco.ToString("F2", CI));
        }
    }
}