using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmandprog
{
    internal class score
    {
        private static int _score;
        private static int balance;
        
        public static int Balance
        {
            
            get { return balance; }
            set { balance = value; }
        }

        public static int InfScore
        {
            get
            {
                return _score;
                
            }
            set { _score = value; }
        }

        public static int Score
        {
            get
            {
                Random random = new Random();
                _score = random.Next(1000, 10000);
                return _score;
            }
        }
    }
}
