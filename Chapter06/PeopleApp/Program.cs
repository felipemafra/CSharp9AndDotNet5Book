using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var harry = new Person
            {Name = "Harry"};

            var mary = new Person
            {Name = "Mary"};

            var jill = new Person
            {Name = "Jill"};

            var baby1 = mary.ProcreateWith(harry);
            baby1.Name = "Gary";

            var baby2 = Person.Procreate(harry, jill);

            WriteLine($"{harry.Name} has {harry.Children.Count}");
            WriteLine($"{mary.Name} has {mary.Children.Count}");
            WriteLine($"{jill.Name} has {jill.Children.Count}");
            WriteLine(
                format: "{0}'s first children is named \"{1}\".",
                arg0: harry.Name,
                arg1: harry.Children[0].Name
            );
        }
    }
}
