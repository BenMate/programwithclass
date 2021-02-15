using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_27_Constructors
{
    public class Animal
    {

        

        public string name = "";

        //constructor
        public Animal(string name)
        {
            this.name = name;
        }


        public void MakeNoise()
        {
            Console.WriteLine(name + ":Made noises");
        }
        // Added the EatFood method
        public virtual void EatFood()
        {
            MakeNoise();
        }
    }

}
