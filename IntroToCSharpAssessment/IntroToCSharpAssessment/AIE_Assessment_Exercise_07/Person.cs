using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_Assessment_Exercise_07
{
    public class Person
    {
        //TODO: SayGreeting function "hello.im -persons name-"
        //TODO: initialize an instance of both person and docter,ouptuts their greetings to console.
        //TODO: both classes implement a public default constructor and a constructor that accepts a string argument
        //      containing the persons name.

      
        public string name = "";
        public string phone = "";
        public string email = "";
       
        
        //public default constructor
        public Person(string name, string phone,string email)
        {
            this.name  = name;
            this.phone = phone;
            this.email = email;
        }

        public void Greetings()
        {
            Console.WriteLine();
        }
    }






}
