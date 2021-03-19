using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamentos
{
    public class PagamentoPix : Pagamento
    {
        public Chave Chave { get; set; }

        public override string ValidaValor()
        {
            return base.ValidaValor() + "AGORA ESTOU DENTRO DO PAGAMENTO PIX!";
        }

        public override string ToString()
        {
            return base.ToString() + "\nChave: " + this.Chave;
        }


    }
}
