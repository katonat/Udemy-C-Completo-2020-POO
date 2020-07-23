using System;
using System.Globalization;

namespace Primeiro {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial? (s/n)");
            char deposito = char.Parse(Console.ReadLine());
            double valor = 0.0;
            if(deposito == 's') {
                Console.WriteLine("Entre o valor de depósito inicial");
                valor = double.Parse(Console.ReadLine());
            }

            Conta c1 = new Conta(numero, titular, valor);

            Console.WriteLine("\nDados da Conta:");
            Console.WriteLine(c1 + "\n");

            Console.Write("Entre com um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine());
            c1.Depositar(valorDeposito);
            Console.WriteLine("Dados da Conta atualizados:");
            Console.WriteLine(c1 + "\n");

            Console.Write("Entre com um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine());
            c1.Sacar(valorSaque);
            Console.WriteLine("Dados da Conta atualizados:");
            Console.WriteLine(c1);

        }
    }
}