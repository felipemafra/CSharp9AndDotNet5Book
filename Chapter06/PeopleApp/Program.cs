using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee john = new Employee
            {
                Name = "John Jones",
                DateOfBirth = new DateTime(1985, 11, 18)
            };

            try
            {
                john.TimeTravel(new DateTime(1999, 12, 31));
                john.TimeTravel(new DateTime(1950, 12, 25));
            }
            catch (PersonException ex)
            {

                WriteLine(ex.Message);
            }
        }
    }
}
