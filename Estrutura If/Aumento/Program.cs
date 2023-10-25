using System;
using System.Globalization;

namespace Aumento {
    class Program {
        static void Main(string[] args) {

            //*
            CultureInfo CI = CultureInfo.InvariantCulture;
            double sal, no, au, po;

            Console.Write("Digite o salário da pessoa: ");
            sal = double.Parse(Console.ReadLine(), CI);

            if (sal <= 1000) {
                no = sal * 0.2;
                po = 20;
                au = sal + no;
            }
            else if (sal > 1000 && sal <= 3000) {
                no = sal * 0.15;
                po = 15;
                au = sal + no;
            }
            else if (sal > 3000 && sal <= 8000) {
                no = sal * 0.1;
                po = 10;
                au = sal + no;
            }
            else {
                no = sal * 0.05;
                po = 5;
                au = sal + no;
            }          

            Console.WriteLine("Novo Salario = R$ " + au.ToString("F2", CI));
            Console.WriteLine("Aumento = R$ " + no.ToString("F2", CI));
            Console.WriteLine("Porcentagem = " + po + "%");
        }
    }
}
