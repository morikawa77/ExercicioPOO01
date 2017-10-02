using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO01.Heranca
{
    public class ContaCorrente : Conta
    {
        
        public ContaCorrente() 
            : base(0.0m)
        {
            
        }
        public ContaCorrente(decimal saldoInicial)
            :base(saldoInicial)
        {

        }

        public decimal Limite { get; set; }
        public bool Cheque { get; set; }

    }
}
