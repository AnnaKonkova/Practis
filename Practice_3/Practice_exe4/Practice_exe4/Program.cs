using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_exe4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r = 4, c = 3;
            int[,] array = new int[r, c];
            Random random = new Random();

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    array[i,j] = random.Next(0, 50);
                    Console.Write($" {array[i, j]}\t");
                }
                Console.WriteLine("");
            }
            
            Console.ReadLine();
        }
    }
}
