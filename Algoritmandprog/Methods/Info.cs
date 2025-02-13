using System;

namespace Algoritmandprog
{
    public class Info
    {
        public static void info()
        {
            Console.WriteLine($"\nИнформация о счете:\n" +
                              $"Номер счета: {score.InfScore}\n" +
                              $"Тип счета: {TypeOfScore.typescore}\n" +
                              $"Баланс счета: {score.Balance}");
        }
    }
}