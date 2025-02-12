using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmandprog
{
    internal class score
    {
        public static int Score (int numberofscore)
        {
            Random Random = new Random();
            numberofscore = Random.Next(1000, 10000);
            return numberofscore;
        }
       


    }
}
