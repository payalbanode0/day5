using System;

namespace Flipcoin
{
    internal class Program
    {
        int number;
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            Flip f = new Flip();
            f.Flipcoinmethod(number);
            Console.ReadLine();

        }
    }
}
