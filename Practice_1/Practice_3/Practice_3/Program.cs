using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;// Для корректной кодировки вывода в консоль ( без этой строки все сиволы "?" )
            int triesCount = 5;
            string password = "1234";
            string userInput;

            for (int i = 0; i < triesCount; i++)
            {
                Console.Write("Введите пароль: ");
                userInput = Console.ReadLine();
                if (userInput == password)
                {
                    Console.WriteLine("Доступ разрешон)");
                    break;
                }
                else
                {
                    Console.WriteLine("Веден не верныйпароль");
                    Console.WriteLine($"У вас осталось {triesCount - i - 1} попыток");
                }
            }
            Console.ReadLine();
        }
    }
}
