using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO01.Heranca
{
    public class PessoaFisica
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public List<IConta> Contas { get; set; }

    }
}
