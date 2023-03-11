using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_exe5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Count(5);

        }
        private static void Count(int count = 10)
        {
            Console.Write("Enter the number of rows of the matrix: ");
            int allRows = int.Parse(Console.ReadLine());

            Random random = new Random();

            int[][] array = new int[allRows][];
            for (int rows = 0; rows < allRows; rows++)
            {
                array[rows] = new int[random.Next(1, 13)];
            }

            for (int rows = 0; rows < allRows; rows++)
            {
                for (int column = 0; column < array[rows].Length; column++)
                {
                    array[rows][column] = random.Next(0, 80);
                }
            }

            Console.WriteLine("Jagged array with random values");
            foreach (int[] i in array)
            {
                foreach (int j in i)
                {
                    Console.Write(" " + j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
