using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine(" Number is an Even Number");
                
            }
            else
            {
                Console.WriteLine("Number is an Odd Number");
                
            }
        }
    }
}