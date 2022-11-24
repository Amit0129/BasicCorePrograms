using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class FlipCoin
    {
        int noOfFlip;
        public FlipCoin(int noOfFlip)
        {
            this.noOfFlip = noOfFlip;
        }
        public void GetPersentage()
        {
            Random random = new Random();
            int headCount = 0;
            int tailCount = 0;
            for (int i = 1; i <= noOfFlip; i++)
            {
                int checkHeadOrTail = random.Next(0,2);
                switch (checkHeadOrTail)
                {
                    case 0:
                        headCount++;
                        break;
                    case 1:
                        tailCount++;
                        break;
                }

            }
            double headPerc = (headCount / (float) this.noOfFlip) * 100;
            double tailPerc = (tailCount / (float) this.noOfFlip) * 100;

            Console.WriteLine(headCount);
            Console.WriteLine(tailCount);
            Console.WriteLine();
            Console.WriteLine("Persentage of head is {0} %",headPerc);
            Console.WriteLine($"Persentage of tail is {tailPerc} %");
        }
    }
}
