using System;

namespace Algoritmandprog
{
    public class Cashout
    {
        public static void cashout(int cash)
        {
            if (cash > score.Balance)
            {
                Console.WriteLine("У вас нету столько денег");
            }
            else
            {
                Console.WriteLine($"На счету осталось: {score.Balance -= cash} руб");
            }
        }
    }
}