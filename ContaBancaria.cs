using System;
using System.Globalization;

namespace Questao1
{
    class ContaBancaria {
        private int Numero {get;}
        public string Titular {get; set;}
        public double Saldo {get; set;}
       
        public ContaBancaria(int _numero, string _titular)
        {
            Numero = _numero;
            Titular = _titular;   
        }

        public ContaBancaria(int _numero, string _titular, 
            double _depositoInicial) : this(_numero, _titular)
        {
            Saldo = _depositoInicial;
        }

        public void Saque(double valor)
        {
            double taxa = 3.5;
            if(valor > 0)
                this.Saldo -= (valor+taxa);
        }
        public void Deposito(double valor)
        {
            if(valor > 0)
                this.Saldo += valor;
        }

        public override string ToString()
        {
            return String.Format("Conta {0}, Titular: {1}, Saldo: $ {2}",
                        this.Numero, this.Titular, 
                        this.Saldo.ToString("0.00", CultureInfo.InvariantCulture));
        }
    }
}
