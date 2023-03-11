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
        var dayDescriber = new Program();

        var values = Enum.GetValues(typeof(DayOfWeek));
        foreach(var day in values)
        {
            dayDescriber.dayProperty = (DayOfWeek)day;
        }

        Console.ReadLine();
    }

   

    public DayOfWeek _dayField;
    public DayOfWeek dayProperty {
        get
        {
            return _dayField;
        }
        set
        {
            _dayField = value;
            PrintDay(dayProperty);
        }
    }
    

    public enum DayOfWeek
    {
        DEFAULT = 0,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    void PrintDay(DayOfWeek DayWeek)
    {
        switch (DayWeek)
        {
            case DayOfWeek.Monday:
                Console.WriteLine("Monday :)");
                break;
            case DayOfWeek.Tuesday:
                Console.WriteLine("Tuesday :)");
                break;
            case DayOfWeek.Thursday:
                Console.WriteLine("Thursday :)");
                break;
            case DayOfWeek.Wednesday:
                Console.WriteLine("Wednesday :)");
                break;
            case DayOfWeek.Friday:
                Console.WriteLine("Friday :)");
                break;
            case DayOfWeek.Saturday:
                Console.WriteLine("Saturday :)");
                break;
            case DayOfWeek.Sunday:
                Console.WriteLine("Sunday :)");
                break;
            default: break;
        }
    }

}

   
