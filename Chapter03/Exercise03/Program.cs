using System;
using static System.Console;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 100;
            for (int i = 1; i < length; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    WriteLine("Buzz");
                }
                else
                {
                    WriteLine(i);
                }
            }
        }
    }
}
