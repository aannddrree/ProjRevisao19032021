using Pagamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjRevisao19032021
{
    class Program
    {
        static void Main(string[] args)
        {
            Pagamento pb = new PagamentoBoleto(1, "Muito Bom!");

            Pagamento pc = new PagamentoCartao()
            {
                Id = 1,
                Descricao = "Top",
                Valor = 2000
            };

            PagamentoPix pix = new PagamentoPix()
            {
                Id = 1,
                Descricao = "Uia",
                Valor = 5000,
                Chave = new Chave()
                {
                    Id = 1,
                    Tipo = "cpf",
                    Valor = 1000
                }
            };

            Console.WriteLine("Validação: " + pix.ValidaValor());

            //Console.WriteLine("Teste Protect: " + pix.ELegal());

            if (pix.IncluirPagamento())
                Console.WriteLine(pix);

            Console.ReadKey();

        }
    }
}
