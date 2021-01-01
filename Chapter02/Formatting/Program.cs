using System;
using static System.Console;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            string applesText = "Apples";
            int applesCount = 1234;
            string bananasText = "Bananas";
            int bananasCount = 56789;
            WriteLine(format: "{0, -8} {1, 6:N0}",
                arg0: "Name",
                arg1: "Count"
            );
            WriteLine(format: "{0, -8} {1, 6:N0}",
                arg0: applesText,
                arg1: applesCount
            );
            WriteLine(format: "{0, -8} {1, 6:N0}",
                arg0: bananasText,
                arg1: bananasCount
            );
        }
    }
}
