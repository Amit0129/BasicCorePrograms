using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class SwapTwoNumbers
    {
        public void SwapTwoNumber()
        {
            int numberOne = 10;
            int numberTwo = 20;

            Console.WriteLine("Number one is {0}", numberOne);
            Console.WriteLine("Number two is {0}", numberTwo);

            int temp = numberOne;
            numberOne = numberTwo;
            numberTwo = temp;

            Console.WriteLine("After Swap");
            Console.WriteLine("Number one is {0}", numberOne);
            Console.WriteLine("Number two is {0}", numberTwo);
        }
        
    }
}
