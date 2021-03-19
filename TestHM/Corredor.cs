using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHM
{
    public class Corredor : Atleta, ICorredor
    {
        public override void VerHabilidades()
        {
            Console.WriteLine("Sabe correr");
        }

        public void Correr()
        {
            Console.WriteLine("Corredor correndo...");
        }
    }
}
