using System;
using System.Globalization;

namespace Troco_Verificado {
    class Program {
        static void Main(string[] args) {

            //* O programa calculará o troco no processo de pagamento de um produto de uma mercearia

            CultureInfo CI = CultureInfo.InvariantCulture;

            int calculo;
            double falta, troco;

            Console.Write("Preço unitário do produto: ");
            int p = int.Parse(Console.ReadLine(), CI);

            Console.Write("Quantidade comprada: ");
            int q = int.Parse(Console.ReadLine(), CI);

            Console.Write("Dinheiro recebido: ");
            int d = int.Parse(Console.ReadLine(), CI);

            calculo = p * q;
            
            if (calculo > d) {
                falta = calculo - d;
                Console.WriteLine("DINHEIRO INSUFICIENTE. FALTAM " + falta.ToString("F2", CI) + " REAIS.");
            }
            else {
                troco = d - calculo;
                Console.WriteLine("TROCO = " + troco.ToString("F2", CI));
            }
        }
    }
}
