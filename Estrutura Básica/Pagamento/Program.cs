using System;
using System.Globalization;

namespace Pagamento {
    class Program {
        static void Main(string[] args) {

            //* O objetivo do programa é ler o nome de um funcionário e calcular quanto ele receberá a partir do quanto de horas extras ele fez.

            CultureInfo CI = CultureInfo.InvariantCulture;
            string nome;
            int vh, ht, pagamento;

            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Valor por hora: ");
            vh = int.Parse(Console.ReadLine(), CI);
            Console.Write("Horas trabalhadas: ");
            ht = int.Parse(Console.ReadLine(), CI);

            pagamento = vh * ht;

            Console.WriteLine("O pagamento para " + nome + " deve ser " + pagamento.ToString("F2", CI));
        }
    }
}