using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_Assessment_Exercise_07
{
    public class Person
    {                
         string name = "";
         string phone = "";
         string email = "";
             
        //public default constructor
        public Person ()
        {

        }
      
        //Constructor that accepts a string argument
        public Person(string name, string phone,string email)
        {
            this.name  = name;
            this.phone = phone;
            this.email = email;
        }

        public virtual void SayGreeting()
        {
            Console.WriteLine($"Hello, Im {name}");
            
        }
    }
}
