using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Person> Children = new List<Person>();

        public static Person Procreate(Person p1, Person p2)
        {
            var baby = new Person
            {
                Name = $"Baby of {p1.Name} and {p2.Name}",
                DateOfBirth = DateTime.Now
            };

            p1.Children.Add(baby);
            p2.Children.Add(baby);

            return baby;
        }

        public Person ProcreateWith(Person partner)
        {
            return Procreate(this, partner);
        }

        // operator to "multiply"
        public static Person operator *(Person p1, Person p2)
        {
            return Person.Procreate(p1, p2);
        }

        // event delegate field
        public event EventHandler Shout;

        //data field
        public int AngerLevel;

        //method
        public void Poke()
        {
            AngerLevel++;
            if (AngerLevel >= 3)
            {
                // if something is listening
                // then call the delegate

                Shout?.Invoke(this, EventArgs.Empty);

                // if (Shout != null)
                // {
                //     Shout(this, EventArgs.Empty);
                // }
            }
        }

        public void TimeTravel(DateTime when)
        {
            if (when <= DateOfBirth)
            {
                throw new PersonException("If you travel back in time to a date earlier than your birth, " +
                    "then the universe will explode!");
            }
            else
            {
                WriteLine($"Welcome to {when:yyyy}!");
            }
        }

        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }

        public override string ToString()
        {
            return $"{Name} was born on a {DateOfBirth:dddd}.";
        }

        public int CompareTo(Person other)
        {
           return Name.CompareTo(other.Name);
        }
    }
}
