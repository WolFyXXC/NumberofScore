using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmandprog
{
    internal class score
    {
        private static int _score = 10000;
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
            get { return _score++; }
        }
    }
}
