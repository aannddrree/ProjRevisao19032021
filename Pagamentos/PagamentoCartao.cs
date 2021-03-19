using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamentos
{
    public class PagamentoCartao : Pagamento
    {
        public PagamentoCartao(int id, string descricao) : base (id, descricao)
        {
            //O que eu quiser...
        }

        public PagamentoCartao() { }
    }
}
