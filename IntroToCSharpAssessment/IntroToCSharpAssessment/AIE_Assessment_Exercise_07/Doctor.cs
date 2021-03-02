using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_Assessment_Exercise_07
{
    public class Doctor: Person
    {
        //template for doctor

         string name = "";

        //default constructor
        public Doctor()
        {

        }

        //Constructor that accepts string value 
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
