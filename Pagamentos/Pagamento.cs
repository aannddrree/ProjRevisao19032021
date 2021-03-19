using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamentos
{
    public abstract class Pagamento : IPagamento
    {
        public Pagamento(int id, string Descricao) { }

        public Pagamento() { }
        #region Propriedades

        public int Id { get; set; }

        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        #endregion

        #region Métodos

        public virtual string ValidaValor()
        {
            if (this.Valor > 10)
                return "é quase lá é maior que 10";
            return "sem comentarios rs";
        }

        protected string ELegal()
        {
            return "Top d+";
        }

        public override string ToString()
        {
            return "Id: " + this.Id + 
                 "\nDescrição: " + this.Descricao + 
                 "\nValor: " + this.Valor;
        }

        public bool IncluirPagamento()
        {
            Console.WriteLine("Entrei na inclusão de pagamento");
            return true;
        }

        #endregion
    }
}
