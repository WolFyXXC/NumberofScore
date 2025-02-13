using System;

namespace Algoritmandprog
{
    internal class Program:TypeOfScore
    { 
        static void Main(string[] args)
        {
            int generatedScore = score.Score;
            TypeOfScore.typeofscore(ansDeposit);
            while (true)
            {
                Console.WriteLine("\n1.Положить на счет средства\n" +
                                  "2.Снять средства со счета\n" +
                                  "3.Информация о счете\n" +
                                  "4.Тип банковского счета\n");
                Console.Write("Выберите метод: "); int cash;
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        if (ansDeposit == false)
                            Console.WriteLine("\nСредства можно положить только на счет \"С пополнением\"");
                        else
                        {
                            Console.Write("\nВведите сумму которую хотитите положить на счет: ");
                            cash = Convert.ToInt32(Console.ReadLine());
                            Cashin.cashin(cash);
                        }
                        break;
                    case 2:
                        Console.Write("\nВведите сумму которую хотите снять: ");
                        cash = Convert.ToInt32(Console.ReadLine());
                        Cashout.cashout(cash);
                        break;
                    case 3:
                        Info.info();
                        break;
                    case 4:
                        TypeOfScore.typeofscore(ansDeposit);
                        break;
                    default:
                        Console.WriteLine("Выберите любой метод из четырех");
                        break;
                }
            }
        }
    }
}
