using System;
using System.Globalization;

namespace Primeiro {

    public class Conta {

        public int Numero { get; private set; }
        public double Saldo { get; private set; }
        public string _titular;


        public Conta(int numero, string titular) {
            Numero = numero;
            this.SetTitular(titular);
        }

        public Conta(int numero, string titular, double deposito) : this(numero, titular) {
            this.Depositar(deposito);
        }

        public string GetTitular() {
            return _titular;
        }

        public void SetTitular(string nome) {
            if(nome != null && nome.Length > 2) {
                _titular = nome;
            }
        }

        public void Depositar(double valor) {
            if(valor > 0)
                Saldo += valor;
        }

        public void Sacar(double valor) {
            Saldo -= (valor+5);
        }

        public override string ToString() {
            return "Conta "
                + Numero
                + ", "
                + "Titular: "
                + _titular
                + ", "
                + "Saldo R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
