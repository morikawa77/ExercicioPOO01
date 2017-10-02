using ExercicioPOO01.Heranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO01
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal saldoInicial = 0.0m;

            Console.Write("Informe o Saldo inicial da Conta: ");
            saldoInicial = Convert.ToDecimal(Console.ReadLine());

            ContaCorrente cc = new ContaCorrente(saldoInicial);

            

            Console.Write("Deseja realizar um Depósito (D) ou Saque (S): ");
            string opcao = Console.ReadLine().ToUpperInvariant();

			Console.Write("Informe o Valor: ");
			decimal valor = Convert.ToDecimal(Console.ReadLine());
			decimal saldo = 0.00m;

            if (opcao != "S" && opcao != "D"){
				Console.Write("Deseja realizar um Depósito (D) ou Saque (S): ");
				opcao = Console.ReadLine().ToUpperInvariant();
				
            } else {
				if (opcao == "S")
				{
                    if (valor > (cc.Saldo + cc.Limite)){
                        Console.WriteLine("Saldo insuficiente.");
                        saldo = saldoInicial;
                    } else {
                        saldo = cc.Saque(valor, DateTime.Now);
                    }
					
				}
				else
				{
					saldo = cc.Deposito(valor, DateTime.Now);
				}
            }

			

            Console.Write("Saldo Final: {0:R$ ###,##0.00}", saldo);
            Console.ReadKey();
            
        }
    }
}