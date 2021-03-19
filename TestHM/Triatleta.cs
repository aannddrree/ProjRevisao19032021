using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHM
{
    public class Triatleta : Atleta, ICorredor, INadador, ICiclista
    {
        public override void VerHabilidades()
        {
            Console.WriteLine("Sabe correr, pedalar e nadar");
        }

        public void Correr()
        {
            new Corredor().Correr();
        }

        public void Nadar()
        {
            new Nadador().Nadar();
        }

        public void Pedalar()
        {
            new Ciclista().Pedalar();
        }
    }
}
