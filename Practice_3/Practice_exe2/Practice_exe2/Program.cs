using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_exe2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[][] arr = new int[n][];
            for (int i = 0; i < n; i++)
            {
                arr[i] = new int[n];
            }

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i][j] = random.Next(0, 2);

                    if (arr[i][j] == 1)
                    {
                        Console.WriteLine($"The element is found and what is its index: [{ i},{ j}]");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
