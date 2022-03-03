using System;

namespace swap
{
    internal class Swap
    {
        static void Main(string[] args)
        {
            int a = 4, b = 10, temp;
            Console.WriteLine("before swap =" + a + "b ="+b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("after swap =" + a + "b=" + b);


        }
    }
}
