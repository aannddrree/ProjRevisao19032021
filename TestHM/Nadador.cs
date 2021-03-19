using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHM
{
    public class Nadador : Atleta, INadador
    {
        public override void VerHabilidades()
        {
            Console.WriteLine("Sabe nadar");
        }

        public void Nadar()
        {
            Console.WriteLine("Nadador nadando...");
        }
    }
}
