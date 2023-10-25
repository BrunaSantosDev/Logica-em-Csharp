using System;
using System.Globalization;

namespace Notas {
    class Program {
        static void Main(string[] args) {

            //* O programa vai avaliar se o aluno foi aprovado ou reprovado.

            CultureInfo CI = CultureInfo.InvariantCulture;
            double n1, n2, nf;

            Console.Write("Digite a primeira nota: ");
            n1 = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine(), CI);

            nf = n1 + n2;
            Console.WriteLine("NOTA FINAL = " + nf.ToString("F1", CI));

            if (nf < 60) {
                Console.WriteLine("REPROVADO");
            }
        }
    }
}
