using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_Assessment_Exercise_07
{
    public class Doctor: Person
    {
       

         string name = "";

        //default constructor for doctor
        public Doctor() : base ("smith", "12345" , "doctor@email.com")
        {

        }

        //Constructor that accepts string arguements 
        public Doctor(string name, string salary, string phone, string email) : base ()
        {
            this.name = name;
        }

        public override void SayGreeting()
        {
           Console.WriteLine($"Hello, Im Dr. {name} ");
        }

    }
}
