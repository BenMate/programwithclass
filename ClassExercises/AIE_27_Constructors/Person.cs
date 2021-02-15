using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_27_Constructors
{
    class Person : Animal
    {
        public Person() : base("bob")
        {
        }

        public void FeedAnimal(Animal animal)
        {
            animal.EatFood();

        }
    }
}
