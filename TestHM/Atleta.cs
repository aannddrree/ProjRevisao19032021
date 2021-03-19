using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHM
{
    public class Atleta : IAtleta
    {
        public virtual void VerHabilidades()
        {
            Console.WriteLine("Nenhuma");
        }
    }
}
