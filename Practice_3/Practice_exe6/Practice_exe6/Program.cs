using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice_exe6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number1 = rand.Next(1, 100);
            int number2 = rand.Next(1, 100);

            ref int o1 = ref number1;
            ref int o2 = ref number2;
           

            Console.WriteLine(o1 + "\n" + o2);

            Console.ReadLine();
            
        }
  
        
    }
}
