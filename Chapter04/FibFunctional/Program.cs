using System;
using static System.Console;

namespace FibFunctional
{
    class Program
    {
        static int FibFunctional(int term) =>
            term switch
            {
                1 => 0,
                2 => 1,
                _ => FibFunctional(term - 1) + FibFunctional(term - 2)
            };
        

        static void RunFibFunctional()
        {
            for (int i = 1; i < 30; i++)
            {
                WriteLine("The {0} term of the Fibonacci sequence is {1:N0}",
                    arg0: i,
                    arg1: FibFunctional(term:  i)
                );
            }
        }

        static void Main(string[] args)
        {
            RunFibFunctional();
        }
    }
}
