using System;

namespace Leapyear
{
    internal class Leapyear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter year");
            int Year = int.Parse(Console.ReadLine());
            if ((Year % 4 == 0) && (Year % 100 != 0)) 
            Console.WriteLine("this is leap year");          
            else
                Console.WriteLine("this is not leap year");

                   
        }
    }
}
