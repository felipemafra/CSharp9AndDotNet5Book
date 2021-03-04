using System;
using System.Reflection;
using static System.Console;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Reflection
{
    class Program
    {
        [Coder("Mark Price", "22 August 2019")]
        [Coder("Johnni Rasmussen", "13 September 2019")]
        public static void DoStuff()
        {}

        static void Main(string[] args)
        {
            Console.WriteLine("Assembly metadata:");
            Assembly assembly = Assembly.GetEntryAssembly();

            WriteLine($"Full name: {assembly.FullName}");
            WriteLine($"Location: {assembly.Location}");

            var attributes = assembly.GetCustomAttributes();

            WriteLine("Attributes:");

            foreach (Attribute a in attributes)
            {
                WriteLine($"{a.GetType()}");
            }

            var version = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
            WriteLine($"Version: {version.InformationalVersion}");

            var company = assembly.GetCustomAttribute<AssemblyCompanyAttribute>();
            WriteLine($"{company.Company}");

            WriteLine("");
            WriteLine($"* Types:");
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                WriteLine($"Type: {type.Name}");
                MemberInfo[] members = type.GetMembers();

                foreach (MemberInfo member in members)
                {
                    WriteLine("{0}: {1} ({2})",
                        arg0: member.MemberType,
                        arg1: member.Name,
                        arg2: member.DeclaringType.Name);

                    var coders = member.GetCustomAttributes<CoderAttribute>()
                                        .OrderByDescending(c => c.LastModified);
                    
                    foreach (CoderAttribute coder in coders)
                    {
                        WriteLine($"Modified by {coder.Coder} on {coder.LastModified.ToShortDateString()}");
                    }
                }                
            }
        }
    }
}
