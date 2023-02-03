using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "ahaha";
            string userInput;

            Console.Write("Введите пароль: ");
            userInput = Console.ReadLine();

            if (userInput == password)
            {
                Console.WriteLine("Пароль принят. Доступ разрешен");
            }
            else
            {
                Console.WriteLine("Неверный пароль. Доступ закрыт");
            }
        }
    }
}