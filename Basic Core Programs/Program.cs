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
            powerOfTwo.GetPowerOfTwoTable();
        }
    }
}