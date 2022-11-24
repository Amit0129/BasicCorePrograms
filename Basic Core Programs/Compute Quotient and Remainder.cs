using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class Compute_Quotient_and_Remainder
    {
        public void GetQuotientAndRemainder()
        {
            int dividend = 70, divisor = 8;

            int Quot = dividend / divisor;
            int rem = dividend % divisor;

            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + Quot);
            Console.WriteLine("Remainder = " + rem);
        }
        
    }
}
