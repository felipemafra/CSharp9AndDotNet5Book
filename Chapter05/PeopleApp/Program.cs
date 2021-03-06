﻿using System;
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
            bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StetueOfZeusAtOlympia;
            bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
            // WriteLine(bob.ToString());
            WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
                      arg0: bob.Name,
                      arg1: bob.DateOfBirth);
            WriteLine($"Bob is {bob.Age} years old.");
            WriteLine(format:
                      "{0}'s favorite wonder is {1}. It's integer is {2}",
                      arg0: bob.Name,
                      arg1: bob.FavoriteAncientWonder,
                      arg2: (int)bob.FavoriteAncientWonder);
            WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

            bob.Children.Add(new Person 
            {
                Name = "Alfred"
            });

            bob.Children.Add(new Person
            {
                Name = "Zoe"
            });

            WriteLine($"{bob.Name} has {bob.Children.Count} children:");
            for (int child = 0; child < bob.Children.Count; child++)
            {
                WriteLine($"{bob.Children[child].Name}");
            }

            int a = 10;
            int b = 20;
            int c = 30;

            WriteLine($"Before: a = {a}, b = {b}, c = {c}");
            bob.PassingParameters(a, ref b, out c);
            WriteLine($"After: a = {a}, b = {b}, c = {c}");

            WriteLine("=========================================================");

            object[] passengers = {
                new FirstClassPassenger {AirMiles = 1_419},
                new FirstClassPassenger {AirMiles = 16_562},
                new BusinessClassPassenger(),
                new CoachClassPasenger {CarryOnKG = 25.7},
                new CoachClassPasenger {CarryOnKG = 0},
            };

            foreach (object passenger in passengers)
            {
                decimal flightCost = passenger switch
                {
                    FirstClassPassenger p => p.AirMiles switch
                    {
                        > 35000 => 1500M,
                        > 15000 => 1750M,
                        _ => 2000M,
                    },
                    BusinessClassPassenger => 1000M,
                    CoachClassPasenger p when p.CarryOnKG < 10.0 => 500M,
                    CoachClassPasenger => 650M,
                    _ => 800M
                };

                WriteLine($"Flight costs {flightCost:C} for {passenger}");
            }
             WriteLine("=======================================");
            var jeff = new ImmutablePerson 
            {
                FirstName = "Jeff",
                LastName = "Winger"
            };

            var car = new ImmutableVehicle
            {
                Brand = "Mazda MX-5 RF",
                Color = "Sour Red Crystal Metalic",
                Wheels = 4
            };

            var repaintedCar = car with
            {
                Color = "Polymetal Grey Metallic"
            };
            WriteLine("Original color was {0}, new color is {1}.",
                arg0: car.Color,
                arg1: repaintedCar.Color
            );

            var oscar = new ImmutableAnimal("Oscar", "Labrador");
            var (who, what) = oscar; // cals Deconstructor method
            WriteLine($"{who} is a {what}.");
        }
    }
}
