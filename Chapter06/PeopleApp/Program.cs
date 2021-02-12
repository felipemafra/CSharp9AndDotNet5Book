using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        private static void Harry_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            WriteLine($"{p.Name} is this angry {p.AngerLevel}.");
        }

        static void Main(string[] args)
        {
            Employee aliceInEmployee = new Employee
            {
                Name = "Alice",
                EmployeeCode = "AA123"
            };
            
            Person aliceInPerson = aliceInEmployee;

            aliceInEmployee.WriteToConsole();
            aliceInPerson.WriteToConsole();
            WriteLine(aliceInEmployee.ToString());
            WriteLine(aliceInPerson.ToString());
        }
    }
}
