using System;
using static System.Console;

namespace FibImperative
{
    class Program
    {
        static int FibImperative(int term)
        {
            if (term == 1)
            {
                return 0;
            }
            else if (term == 2)
            {
                return 1;
                
            }
            else
            {
                return FibImperative(term - 1) + FibImperative(term - 2);
            }
        }

        static void RunFibImperative()
        {
            for (int i = 1; i < 30; i++)
            {
                WriteLine("The {0} term of the Fibonacci sequence is {1:N0}",
                    arg0: i,
                    arg1: FibImperative(term:  i)
                );
            }
        }

        static void Main(string[] args)
        {
            RunFibImperative();
        }
    }
}
