using System;

namespace factor
{
    internal class Poweroftwo
    {


        public static void Main(string[] args)
        {
            Console.WriteLine("enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());
            factor(number);

        }
        public static void factor(int n)
        {
            int result = 1;
            while (n != 0)
            {
                result *= n;
                n--;
                Console.WriteLine($"result is=  {result}");

            }
        }

    }


}
