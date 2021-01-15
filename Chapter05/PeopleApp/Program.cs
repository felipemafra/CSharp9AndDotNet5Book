using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bob = new Person();
            bob.Name = "Bob Smith";
            bob.DateOfBirth = new DateTime(1965, 12, 22);
            WriteLine(bob.ToString());
            WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
                      arg0: bob.Name,
                      arg1: bob.DateOfBirth);
        }
    }
}
