﻿using System;
using System.Globalization;

namespace Crescente {
    class Program {
        static void Main(string[] args) {

            //*
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            int x, y;

            Console.WriteLine("Digite dois números:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            while (x != y) {
                if (x > y) {
                    Console.WriteLine("DECRESCENTE!");
                }
                else {
                    Console.WriteLine("CRESCENTE!");
                }
                return;
            }
        }
    }
}