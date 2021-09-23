﻿using System;

namespace CatsAndDogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you more like a cat or a dog?");
            string userChoice = Convert.ToString(Console.ReadLine().ToUpper());

            if (userChoice == "CAT") 
            {
                Console.WriteLine("You are a home-lover.");
            }
            else if (userChoice == "DOG")
            {
                Console.WriteLine("You are a partygoer.");
            }
            else
            {
                Console.WriteLine($"You are a {userChoice} friend.");
            }

        }
    }
}
