namespace Basic_Core_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Core Programs Main Program");

            //FlipCoinProblem
            FlipCoin flipCoin = new FlipCoin(10);
            //flipCoin.GetPersentage();

            //Leap Year Program
            LeapYear leapYear = new LeapYear();
            //leapYear.CheckLeapYear();

            //Power Of Two Program
            PowerOfTwo powerOfTwo = new PowerOfTwo();
            //powerOfTwo.GetPowerOfTwoTable();

            //Harmonic Number Program
            HarmonicNumber harmonicNumber = new HarmonicNumber();
            //harmonicNumber.GetHarmonicValue();

            //Compute Quotient and Remainder
            Compute_Quotient_and_Remainder compute = new Compute_Quotient_and_Remainder();
            //compute.GetQuotientAndRemainder();

            //Swap Two Number
            SwapTwoNumbers swapTwoNumbers = new SwapTwoNumbers();
            //swapTwoNumbers.SwapTwoNumber();

            //Evem Or Odd program
            EvenOdd evenOdd = new EvenOdd();
            //evenOdd.CheckEvenorOdd();

            //Alphabet is Vowel or Consonant
            VowelOr_Consonant vowelOr_Consonant = new VowelOr_Consonant();
            //vowelOr_Consonant.CheckVowelOrConsonant();

            //Largest Among Three Numbers Program
            LargrstAmongThreeNum largrstAmongThreeNum = new LargrstAmongThreeNum();
            largrstAmongThreeNum.GetLargest();

        }
    }
}