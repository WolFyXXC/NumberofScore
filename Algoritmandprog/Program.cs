using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmandprog
{
    internal class Balance
    {
        private readonly int balance = 38000;

        public int B
        {
            get { return balance; }
            //set { balance = value; }
            //public int GetBalance()
            //{
            //    return balance;
            //}

            //public void SetBalance(int balance)
            //{
            //    balance = value;
            //}
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {          
            Balance balance = new Balance();
            int numberofscore = 0;         
            int scorenumb = score.Score(numberofscore);
            Console.WriteLine("Сколько денег у вас на счете? ");
            //balance.B = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"\nНомер счета: {scorenumb}");

            Console.WriteLine($"Баланс счета: {balance.B}");
        }
    }
}
