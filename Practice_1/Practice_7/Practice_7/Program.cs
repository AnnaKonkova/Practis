using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            bool isOpen = true;
            Table[] tables = { new Table(1, 3), new Table(2, 6), new Table(3, 9) };

            while(isOpen )
            {
                Console.WriteLine("Администратор кафе. \n");

                for (int i =0; i< tables.Length; i++)
                {
                    tables[i].ShowInfo();
                }

                Console.Write("\nВведите ноер стола: ");
                int wishTable =  Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Write("Ведите колличество мест для брони: ");
                int desiredPlaces = Convert.ToInt32(Console.ReadLine());

                bool isReservationComleted = tables[wishTable].Reserve(desiredPlaces);

                if(isReservationComleted)
                {
                    Console.WriteLine("Бронь прошла успешно");
                }
                else
                {
                    Console.WriteLine("Бронь не прошла. Недостаточно мест");
                }

                Console.ReadKey();  
                Console.Clear();
            }
             
        }
    }

    class Table
    {
        public int Number;
        public int MaxPlaces;
        public int FreePleaces;
        public Table(int number, int maxPlaces)
        {
            Number = number;
            MaxPlaces = maxPlaces;
            FreePleaces = maxPlaces;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Стол: {Number}. свободно мест: {FreePleaces} из {MaxPlaces}");
        }

        public bool Reserve( int pleces)
        {
            if(FreePleaces>= pleces)
            {
                FreePleaces -= pleces;
                return true;
            }
            else
            {
                return false; 
            }
        }
    }
}
