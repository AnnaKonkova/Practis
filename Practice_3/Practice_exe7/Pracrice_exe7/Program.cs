using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Pracrice_exe7.Program;

namespace Pracrice_exe7;

    internal class Program
    {
        
        static void Main(string[] args)
        {
            var executive = new Program();
            executive.Start();

            public deywek DayWeek;
            deywek dayWeekModified;

            public enum deywek
            {
                Monday,
                Tuesday,
                Wednesday,
                Thursday,
                Friday,
                Saturday,
                Sunday
            }
            
        }
        void Start()
        {
            PrintDay(DayWeek);
            dayWeekModified = DayWeek;
        }

        void Check()
        {
            if (dayWeekModified != DayWeek)
            {
                dayWeekModified = DayWeek;
                Console.WriteLine(dayWeekModified);
            }
        }

        void PrintDay(deywek DayWeek)
            {
                switch (DayWeek)
                {
                    case deywek.Monday:
                        Console.WriteLine("Monday :)");
                        break;
                    case deywek.Tuesday:
                        Console.WriteLine("Tuesday :)");
                        break;
                    case deywek.Thursday:
                        Console.WriteLine("Thursday :)");
                        break;
                    case deywek.Wednesday:
                        Console.WriteLine("Wednesday :)");
                        break;
                    case deywek.Friday:
                        Console.WriteLine("Friday :)");
                        break;
                    case deywek.Saturday:
                        Console.WriteLine("Saturday :)");
                        break;
                    case deywek.Sunday:
                        Console.WriteLine("Sunday :)");
                        break;
                }
            }
    }       
}
