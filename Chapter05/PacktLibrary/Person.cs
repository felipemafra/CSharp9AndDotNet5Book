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
    }
}
