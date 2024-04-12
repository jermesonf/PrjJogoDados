using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjJogoDados
{
    public class Sortea
    {

        public int sortear()
        {
            Random rand = new Random(); 

            return rand.Next(5);
            
        }

        

        

    }
}
