using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = System.Text.Encoding.UTF8;// Для корректной кодировки вывода в консоль +
            // ( без этой строки все сиволы "?" )

            float health;
            int armor;
            int damage;
            int precentConverter = 100;

            Console.Write("Веедите количество здоровья:");
            health = Convert.ToInt32(Console.ReadLine());
            Console.Write("Веедите количество брони:");
            armor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Веедите количество урона:");
            damage = Convert.ToInt32(Console.ReadLine());

            // health -= damage * armor / precentConverter;
            health -= Convert.ToSingle(damage) / precentConverter * armor;

            Console.WriteLine($"Вам нанесли {damage} уроана. У вас оталось {health} здоровья");
            Console.ReadLine();
        }
    }
}
