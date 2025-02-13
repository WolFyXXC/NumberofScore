using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmandprog
{
    internal class Program:TypeOfScore
    { 
       
        static void Main(string[] args)
        {  
            TypeOfScore.typeofscore(ansDeposit);
            Console.WriteLine($"Номер счета: {score.Score}");
            Console.WriteLine($"Баланс счета: {score.Balance}");
            Console.WriteLine(ansDeposit);
            
            Console.WriteLine("1.Положить на счет средства\n" +
                              "2.Снять средства со счета\n" +
                              "3.Информация о счете\n" +
                              "4.Тип банковского счета\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            int cash;
            switch (choice)
            {
                case 1:
                    if (ansDeposit == false)
                        Console.WriteLine("средства можно положить только на счет \"С пополнением\"");
                    else
                    {
                        Console.WriteLine("Введите сумму которую хотитите положить на счет: ");
                        cash = Convert.ToInt32(Console.ReadLine());
                        Cashin.cashin(cash);
                    }

                    break;
                case 2:
                    Console.WriteLine("Введите сумму которую хотите снять: ");
                    cash = Convert.ToInt32(Console.ReadLine());
                    Cashout.cashout(cash);
                    break;
                case 3:
                    Info.info();
                    break;
                case 4:

                    break;
                default:
                    Console.WriteLine("Выберите любой метод из четырех");
                    break;
            }
            
        }
    }
}
