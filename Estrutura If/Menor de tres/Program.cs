using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace MenorDeTres {
    class Program {
        static void Main(string[] args) {

            //*
            CultureInfo CI = CultureInfo.InvariantCulture;
            int p, s, t, menor;

            Console.Write("Primeiro valor: ");
            p = int.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            s = int.Parse(Console.ReadLine());
            Console.Write("Terceiro valor: ");
            t = int.Parse(Console.ReadLine());

            if ((p < s) && (p < t)) {
                menor = p;
            }
            else if (s < t) {
                menor = s;
            }
            else {
                menor = t;
            }

            Console.WriteLine("MENOR = " + menor);
        }
    }
}
