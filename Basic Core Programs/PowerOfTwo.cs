using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class PowerOfTwo
    {
        public void GetPowerOfTwoTable()
        {
            Console.WriteLine("Enter a number between 0-30");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                int temp = (int)Math.Pow(2, i);
                Console.WriteLine($"{i} to the power 2 is {temp}");
            }
        }
    }
}
