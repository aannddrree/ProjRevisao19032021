using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestHM;

namespace ExecHM
{
    class Program
    {
        static void TorneioDeNatacao(INadador atleta)
        {
            atleta.Nadar();
            atleta.VerHabilidades(); // método polimórfico
        }

        static void TorneioDeCiclismo(ICiclista atleta)
        {
            atleta.Pedalar();
            atleta.VerHabilidades(); // método polimórfico
        }

        static void TorneioDeAtletismo(ICorredor atleta)
        {
            atleta.Correr();
            atleta.VerHabilidades(); // método polimórfico
        }

        static void TorneioDeTriatlon(Triatleta atleta)
        {
            atleta.Nadar();
            atleta.Pedalar();
            atleta.Correr();
            atleta.VerHabilidades(); // método polimórfico
        }

        static void Main(string[] args)
        {

            Nadador nadador = new Nadador();
            Ciclista ciclista = new Ciclista();
            Corredor corredor = new Corredor();

            TorneioDeAtletismo(corredor);
            TorneioDeCiclismo(ciclista);
            TorneioDeNatacao(nadador);

            Triatleta triatleta = new Triatleta();

            TorneioDeAtletismo(triatleta);
            TorneioDeCiclismo(triatleta);
            TorneioDeNatacao(triatleta);
            TorneioDeTriatlon(triatleta);

            Console.ReadKey();
        }
    }
}
