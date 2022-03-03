using System;

namespace powerof_two
{
    internal class Poweroftwo
    {


        public static void Main(string[] args)
        {
            Console.WriteLine("enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());
            powerof_two(number);

        }
      public static void powerof_two(int n)
        {
            int result = 1;
            while(n!=0)
            {
                result *= 2;
                n--;
                Console.WriteLine(result);
                   
            }
        }
    
    }


}
