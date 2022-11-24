using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class EvenOdd
    {
        public void CheckEvenorOdd()
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"The number {number} is Even");
            }
            else
            {
                Console.WriteLine($"The number {number} is Odd");
            }
        }
    }
}
