﻿/*
 * Appendix 4 - Exercise 1: Greetings
 */

using System;
//           rename namespace "Greetings" ?
namespace AIE_Assessment_Exercise_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO:
            // Create instances of
            // - A Person and Doctor classes. 
            
             Person p1 = new Person("Bob", "246810", "BobTheBuilder@something.com");
             
             Doctor p2 = new Doctor("Fred", "40,000", "123456789", "FredFromBuffy@something.com");
             
             Person p3 = new Doctor("Ted", "50,000","987654321","Tedbear@something.com");

            // Invoke the "SayGreeting" method on the above instances
             p1.SayGreeting(); // hello I'm Bob
             p2.SayGreeting(); // hello I'm Dr. Fred
             p3.SayGreeting(); // hello I'm Dr. Ted
        }
    }
}
