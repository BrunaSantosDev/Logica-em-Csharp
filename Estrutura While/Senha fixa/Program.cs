using System;
using System.Globalization;

namespace senha_fixa {
    class Program {
        static void Main(string[] args) {

            CultureInfo cultureInfo = CultureInfo.InvariantCulture;

            Console.Write("Digite a senha: ");
            int x = int.Parse(Console.ReadLine());

            while (x != 2002) {
                Console.Write("Senha Invalida! Tente novamente: ");
                x = int.Parse(Console.ReadLine());             
            }

            Console.WriteLine("Acesso permitido!");
        }
    }
}