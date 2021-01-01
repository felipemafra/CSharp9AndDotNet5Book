using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            uint naturalNumber =23;
            int integerNumber = -23;
            float realNumber = 2.3F;
            double anotherRealNumber = 2.3;
            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;

            Console.WriteLine(naturalNumber);
            Console.WriteLine(integerNumber);
            Console.WriteLine(realNumber);
            Console.WriteLine(anotherRealNumber);
            Console.WriteLine(decimalNotation);
            Console.WriteLine(binaryNotation);
            Console.WriteLine($"{decimalNotation == binaryNotation}");
            Console.WriteLine($"int uses {sizeof(int)} bytes and can store number in range {int.MinValue:N0} to {int.MaxValue:N0}.");
            Console.WriteLine();
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store number in range {double.MinValue:N0} to {double.MaxValue:N0}.");
            Console.WriteLine();
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store number in range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");
        }
    }
}
