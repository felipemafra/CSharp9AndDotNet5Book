using System;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public WondersOfTheAncientWorld FavoriteAncientWonder { get; set; }
        public WondersOfTheAncientWorld BucketList { get; set; }
        public List<Person> Children = new List<Person>();

        public int Age => DateTime.Today.Subtract(DateOfBirth).Days / 365;
        
        private string homePlanet;
        public string HomePlanet
        {
            get { return $"{Name} was born on {HomePlanet}"; }
            set { homePlanet = value; }
        }
        
        public void PassingParameters(int x, ref int y, out int z)
        {
            // out parameters cannot have a default and must be initialized inside the method
            z = 99;

            x++;
            y++;
            z++;
        }
    }
}
