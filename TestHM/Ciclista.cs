using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHM
{
    public class Ciclista : Atleta, ICiclista
    {
        public override void VerHabilidades()
        {
            Console.WriteLine("Sabe pedalar");
        }

        public void Pedalar()
        {
            Console.WriteLine("Ciclista pedalando...");
        }
    }
}
