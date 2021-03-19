using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamentos
{
    public class PagamentoBoleto : Pagamento
    {

        public PagamentoBoleto(int id, string descricao) : base(id, descricao)
        {
            this.Id = id;
            this.Descricao = descricao;
        }

        public void TesteProtected()
        {
            this.ELegal();
        }
    }
}
