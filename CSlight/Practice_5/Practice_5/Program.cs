using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;// Для корректной кодировки вывода в консоль ( без этой строки все сиволы "?" )

            bool isOpen = true;
            string[,] books =
            {
                {"Джеффри Рихер","Роберт Мартин","Адитья Бахвргова"},
                {"Джеси Шелл","Марк Цукерберг","Говард Лавкрафт"},
                {"Александр Пушкин","Михаил Лермонтов","Сергей Есенин"}
            };

            while (isOpen)
            {
                Console.SetCursorPosition(0, 20);
                Console.WriteLine("Весь список авторов:\n");
                for (int i = 0; i < books.GetLength(0); i++)
                {
                    for (int j = 0; j < books.GetLength(1); j++)
                    {
                        Console.WriteLine(books[i, j] + " | ");
                    }
                    Console.WriteLine();
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Библиотека");
                Console.WriteLine("\n1- узнать имя автора по индексу книги.\n\n2- найти книгу по автору.\n\n3 - выход.");
                Console.Write("\nВыберите пункт в меню: ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int line, column;
                        Console.Write("Введите номер полки: ");
                        line = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.Write("Введите номер столбца: ");
                        column = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine($"Это автор: {books[line, column]}");

                        break;
                    case 2:
                        string author;
                        bool authorIsFound = false;
                        Console.WriteLine("Введите автора: ");

                        author = Console.ReadLine();
                        for (int i = 0; i < books.GetLength(0); i++)
                        {
                            for (int j = 0; j < books.GetLength(1); j++)
                            {
                                if (author.ToLower() == books[i, j].ToLower())
                                {
                                    Console.WriteLine($"Автор {books[i, j]} находится на полке {i + 1}{j + 1}");
                                    authorIsFound = true;
                                }
                            }
                        }
                        if(authorIsFound==false)
                        {
                            Console.WriteLine("Такого автора нет");
                        }
                        break;
                    case 3:
                        isOpen = false;
                        break;
                    default:
                        Console.WriteLine("Ввeдeна неверная команда ");

                        break;
                }

                if (isOpen)
                {
                    Console.WriteLine("\nНажмите любую клавишу для продолжения");
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
