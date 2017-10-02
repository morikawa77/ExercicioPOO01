using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO01.Heranca
{
    public class ContaPoupanca : Conta
    {
        public decimal Remuneracao { get; set; }

        public IList<DateTime> Vencimentos { get; set; }
        public ContaPoupanca () : base(0.0m)
        {

        }
        public ContaPoupanca(decimal saldoInicial) 
            : base(saldoInicial)
        {
        }
    }
}
