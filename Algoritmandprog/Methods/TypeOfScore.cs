using System;

namespace Algoritmandprog
{
    public class TypeOfScore
    {
        public static bool ansDeposit;
        public static bool typeofscore(bool ansDeposit)
        {
            Console.WriteLine("Тип банковского счета:\n" +
            "1.С пополнением\n" +
            "2.Без пополнения\n");
            int a = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                switch (a)
                {
                    case 1:
                        return TypeOfScore.ansDeposit = true;
                    case 2:
                        return TypeOfScore.ansDeposit = false;
                    default:
                        throw new ArgumentException(
                            "Выберите либо счет с пополнением (1) или счет без пополнения (2).");
                }
            }
        }
        public static string typescore
        {
            get
            {
                if (ansDeposit)
                    return "С пополнением";
                else
                    return "Без пополнения";
            }
        }
    }
}