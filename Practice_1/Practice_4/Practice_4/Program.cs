using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;// Для корректной кодировки вывода в консоль ( без этой строки все сиволы "?" )

            int[] sectors = { 6, 15, 28, 14, 10 };
            bool isOpen = true;

            while (isOpen)
            {
                Console.SetCursorPosition(0, 15);
                for (int i = 0; i < sectors.Length; i++)
                {
                    Console.WriteLine($"В секторе {i + 1} свободно {sectors[i]} мест ");
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Регистрация рейса.");
                Console.WriteLine("\n\n1 -забронировать места.\n\n2 - выход из программы.\n\n ");
                Console.Write("Введите номер команды: ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int userSector, userPlaseAmount;
                        Console.Write("В каком секторе вы хотите лететь? ");
                        userSector = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (sectors.Length <= userSector || userSector < 0)
                        {
                            Console.WriteLine("Токого сектора не существует.");
                            break;

                        }
                        Console.Write("Сколько мест вы хотите? ");
                        userPlaseAmount = Convert.ToInt32(Console.ReadLine());
                        if (userPlaseAmount < 0)
                        {
                            Console.WriteLine("Неверное колличество мест");
                            break;
                        }
                        if (sectors[userSector] < userPlaseAmount)
                        {
                            Console.WriteLine($"В секторе {userSector + 1} недостаточно мест." +  // Здесь я добавила к "userSector"+1 так,как в строке 35 мы из переменной ее вычли,
             //  соответственно при ее дольнейшем вызове ее значение было измененным, в видиоуроке этого не учли 
                                $" Остаток {sectors[userSector]} "); ;
                            break;
                        }

                        sectors[userSector] -= userPlaseAmount;
                        Console.WriteLine("Бронирование произошло успешно!");
                        break;
                    case 2:
                        isOpen = false;
                        break;

                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
