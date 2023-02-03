using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money;
            int food;
            int foodUnitPrice = 10;
            bool isAbleToPay;

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Добро пожаловать в пекарню! Сегодня еда по"+ foodUnitPrice + " монет.");
            Console.Write("Сколоко у вас монет ?");
            money = Convert.ToInt32(Console.ReadLine());
            Console.Write("Какое количество еды вам нужно");
            food = Convert.ToInt32(Console.ReadLine());

            isAbleToPay = money >= food * foodUnitPrice;
            food *= Convert.ToInt32(isAbleToPay);
            money -= food * foodUnitPrice;
                

            Console.WriteLine($"У вас в сумке {food} ед еды, и {money} монет.");
            Console.ReadLine();
        }
    }
}
