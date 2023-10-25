using System;
using System.Globalization;

namespace Duracao {
    class Program {
       static void Main(string[] args) {
            
            //* O programa converte segundos em horas/minutos/segundos.

            CultureInfo CI = CultureInfo.InvariantCulture;
            int d, h, m, s, r;

            Console.Write("Digite a duração em segundos: ");
            d = int.Parse(Console.ReadLine());

            h = d / 3600;
            r = d % 3600;
            m = r / 60;
            s = r % 60;

            Console.WriteLine(h + ":" + m + ":" + s);
        }
    }
}