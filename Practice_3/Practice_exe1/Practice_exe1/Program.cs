using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_exe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5, max = 0;
            int[,] arr = new int[n, n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = random.Next(-5, 100);
                }
            }

            int min = max;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                    Console.Write($" {arr[i, j]}\t");
                }
                Console.WriteLine("|");
            }

            int[] maxmin = { max, min };
            Console.WriteLine("Minimum and maximum array element:\t");
            for (int i = 0; i < maxmin.Length; i++)
                Console.WriteLine(maxmin[i] + "\t");
            //Console.WriteLine($"Max value is Min {maxmin}");
            Console.WriteLine($"number of elements of the source array {n * n}");
            Console.ReadLine();
        }
    }
}
