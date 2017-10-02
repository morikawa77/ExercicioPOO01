using System;

namespace ExercicioPOO01.Heranca
{
    public interface IConta
    {
        int Agencia { get; set; }
        string Banco { get; set; }
        PessoaFisica Cliente { get; set; }
        int Numero { get; set; }
        decimal Saldo { get; }

        decimal Deposito(decimal valor, DateTime data);
        decimal Saque(decimal valor, DateTime data);
    }
}