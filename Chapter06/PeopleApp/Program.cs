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
            var harry = new Person
            {Name = "Harry"};

            var mary = new Person
            {Name = "Mary"};

            var jill = new Person
            {Name = "Jill"};

            var baby1 = mary.ProcreateWith(harry);
            baby1.Name = "Gary";

            var baby2 = Person.Procreate(harry, jill);

            var baby3 = harry * mary;

            WriteLine($"{harry.Name} has {harry.Children.Count}");
            WriteLine($"{mary.Name} has {mary.Children.Count}");
            WriteLine($"{jill.Name} has {jill.Children.Count}");
            WriteLine(
                format: "{0}'s first children is named \"{1}\".",
                arg0: harry.Name,
                arg1: harry.Children[0].Name
            );
            WriteLine($"Baby3: {baby3}");

            WriteLine("****************************************");
            harry.Shout += Harry_Shout;
            harry.Poke();
            harry.Poke();
            harry.Poke();
            harry.Poke(); 
            WriteLine("****************************************");
            Person[] people = 
            {
                new Person { Name = "Simon"},
                new Person { Name = "Jenny"},
                new Person { Name = "Adam"},
                new Person { Name = "Richard"},
            };

            WriteLine("Initial list of people:");
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");                                
            }
            WriteLine("Use Person's IComparale implementation to sort:");
            Array.Sort(people);
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");                                
            }
        }
    }
}
