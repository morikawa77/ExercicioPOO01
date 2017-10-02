using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO01.Heranca
{
    public abstract class Conta : IConta
    {
        public PessoaFisica Cliente { get; set; }

        private decimal saldo;
        public string Banco { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public decimal Saldo { get { return saldo; }  }
        public Conta(decimal saldoInicial)
        {
            saldo = saldoInicial;
        }
        public decimal Deposito(decimal valor, 
            DateTime data)
        {
            saldo += valor;
            return Saldo;
        }
        public decimal Saque(decimal valor, 
            DateTime data)
        {
				saldo -= valor;
				return Saldo;

        }

    }
}
