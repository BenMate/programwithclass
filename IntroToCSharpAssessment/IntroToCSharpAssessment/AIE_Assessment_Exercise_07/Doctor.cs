using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_Assessment_Exercise_07
{
    public class Doctor
    {
        //template for doctor

        public string salary = "";

        public Doctor()
        {

        }

        public Doctor(string salary)
        {
            this.salary = salary;
        }

        public void Greetings()
        {
            Console.WriteLine();
        }

    }
}
