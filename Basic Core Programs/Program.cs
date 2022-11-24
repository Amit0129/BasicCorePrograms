namespace Basic_Core_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Core Programs Main Program");

            FlipCoin flipCoin = new FlipCoin(10);
            flipCoin.GetPersentage();
        }
    }
}