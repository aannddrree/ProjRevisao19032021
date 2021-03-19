namespace Pagamentos
{
    public class Chave
    {

        #region Propriedades
        public int Id { get; set; }
        public string Tipo { get; set; }
        public decimal Valor { get; set; }

        #endregion

        #region Métodos

        public override string ToString()
        {
            return "Tipo: " + this.Tipo + " Valor: " + this.Valor;
        }

        #endregion
    }
}