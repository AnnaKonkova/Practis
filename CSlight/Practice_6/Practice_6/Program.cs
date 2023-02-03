using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_6
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;// Для корректной кодировки вывода в консоль ( без этой строки все сиволы "?" )
            char[,] map = ReadMap("map.txt");
            DrawMap(map);
        }

         private static char[,] ReadMap(string path)
        {
            string[] file=File.ReadAllLines("map.txt");

            char[,] map = new char[GetMaxLengthOfline(file), file.Length];

            for(int x =0; x<map.GetLength(0); x++)
                for(int y = 0; y < map.GetLength(0); y++)
                    map[x, y] = file[y][x];

            return map;
        }

        private static void DrawMap(char[,] map)
        {
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)

                {
                    Console.Write(map[x, y]);
                }
                Console.Write("\n");
            }
                
                    
        }
        private static int GetMaxLengthOfline(string[] lines)
        {
            int maxLength = lines[0].Length;

            foreach(var line in lines)
                if(line.Length>maxLength)
                    maxLength= line.Length;
            return maxLength;
        }
    }
}
