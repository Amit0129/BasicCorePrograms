using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class HarmonicNumber
    {
        public void GetHarmonicValue()
        {
            Console.WriteLine("Enter a number");
            double num = Convert.ToDouble(Convert.ToInt32(Console.ReadLine()));
            double result = 0;

            for (int i = 1; i < num; i++)
            {
                double temp = 1 / (float)i;
                result += temp;
            }
            Console.WriteLine($"The Harmoic Value of {num} is {result}");
        }
    }
}
