using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_exe3
{
    internal class Program
    {
        internal int n { get; set; }

        //public int Narray_1, Narray_2;

        static void Main()
        {
            Exercise1();
            var executive = new Program();
            executive.Exercise2();

        }
        static void Exercise1()
        {
            int n = 5, max = 0;
            int[,] array = new int[n, n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(0,80);
                }
            }

            int min = max;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                    Console.Write($" {array[i, j]}\t");
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
        void Exercise2()
        {
            //var n = 10;
            //if(this.n == n)
            //{

            //}
            int[][] array = new int[n][];
            for (int i = 0; i < n; i++)
            {
                array[i] = new int[n];
            }

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i][j] = random.Next(0, 2);

                    if (array[i][j] == 1)
                    {
                        Console.WriteLine($"The element is found and what is its index: [{i},{j}]");
                    }
                }
            }

            Console.ReadLine();
        }
    }

}
