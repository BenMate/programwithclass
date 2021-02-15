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
      

     
    }
}
    



