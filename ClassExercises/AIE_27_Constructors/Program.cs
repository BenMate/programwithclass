using System;

namespace AIE_27_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog dog = new Dog();
            Cat cat = new Cat();
            Bird bird = new Bird();
            Person bob = new Person();


            
            bob.FeedAnimal(dog);    
            bob.FeedAnimal(cat);    
            bob.FeedAnimal(bird);
            bob.FeedAnimal(bob);
        }
        class Person : Animal
        {
            public Person() : base("bob")
            {
            }

            public void FeedAnimal (Animal animal)
            {
                animal.EatFood();

            }
        }

        class Animal
        {
            public string name = "";

            //constructor
            public Animal (string name)
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

        class Dog : Animal
        {
            public Dog () : base ("dog")
            {
            }
        }
       

        class Cat : Animal
        {
            public Cat() : base("cat")
            {
            }
        }

        class Bird : Animal
        {
            public Bird() : base("bird")
            {
            }
        }


        class SomeAnimal : Animal
        {
            public SomeAnimal() : base("snake")
            {
            }
        }


    }

}
    



