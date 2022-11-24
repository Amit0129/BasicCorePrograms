using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class LeapYear
    {
        public void CheckLeapYear()
        {
            Console.WriteLine("Enter year you want to check Leap year or not");
            int year = Convert.ToInt32(Console.ReadLine());
            if(year % 400 == 0)
            {
                Console.WriteLine($"Year {year} is Leap Year");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine($"Year {year} is not a leap year");
            }
            else if (year % 4 ==0)
            {
                Console.WriteLine($"Year {year} is Leap Year");
            }
            else
            {
                Console.WriteLine($"Year {year} is not a leap year");
            }
        }
    }
}
