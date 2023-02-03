using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;// Для корректной кодировки вывода в консоль ( без этой строки все сиволы "?" )

            float rublesinWallet;
            float dollarsinWallet;

            int rubToUsd = 64, usdToRub=69;
            float exchangeCurrencyCount;

            string desiredOperation;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine("Добро пожаловать в обменник валют!");

            Console.Write("Введите баланс рублей: ");
            rublesinWallet = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс долларов: ");
            dollarsinWallet = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Выберите необходимую операцию. ");
            Console.WriteLine("1 - обменять рубли на доллары ");
            Console.WriteLine("2 - обменять доллары на рубли ");
            Console.Write("Ваш выбор: ");
            desiredOperation = Console.ReadLine();

            switch(desiredOperation)
            {
                case "1":
                    Console.WriteLine("Обмен рублями на доллары ");
                    Console.Write("Сколько вы хотите обменять? ");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if(rublesinWallet>=exchangeCurrencyCount)
                    {
                        rublesinWallet -= exchangeCurrencyCount;
                        dollarsinWallet+=exchangeCurrencyCount/rubToUsd;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое колличество рублей ");
                    }
                    break;
                case "2":
                    Console.WriteLine("Обмен долларов на рубли ");
                    Console.Write("Сколько вы хотите обменять? ");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (dollarsinWallet >= exchangeCurrencyCount)
                    {
                        rublesinWallet -= exchangeCurrencyCount;
                        dollarsinWallet += exchangeCurrencyCount * usdToRub;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое колличество долларов ");
                    }
                    break;
                    break;
                default:
                    Console.WriteLine("Неверная операция");
                    break;
            }

            Console.WriteLine($"Ваш баланс:{rublesinWallet} рублей "
                + $"\nВаш баланс:{dollarsinWallet} долларов");
            Console.ReadLine();

        }
    }
}
