using System;
using System.Globalization;

 namespace temperatura {
    class Program {
        static void Main(string[] args) {

            //* Converte Celsius para Fahrenheit ou vice-versa

            CultureInfo CI = CultureInfo.InvariantCulture;
            double fa, ce;
            char escolha;

            Console.Write("Voce vai digitar a temperatura em qual escala (C/F)? ");
            escolha = char.Parse(Console.ReadLine());

            if (escolha == 'F' || escolha == 'f') {
                Console.Write("Digite a temperatura em Fahrenheit: ");
                fa = double.Parse(Console.ReadLine(), CI);

                ce = (5.0 / 9.0) * (fa - 32);
                Console.Write("Temperatura equivalente em Celsius: " + ce.ToString("F2", CI));
            }
            else {
                Console.Write("Digite a temperatura em Celsius: ");
                ce = double.Parse(Console.ReadLine(), CI);

                fa = (ce * 9.0 / 5.0) + 32;
                Console.Write("Temperatura equivalente em Fahrenheit: " + fa.ToString("F2", CI));
            }      
        }
    }
}
