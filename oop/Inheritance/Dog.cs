using System;
namespace Inheritance
{

    class Dog : Animal
    {

        public int legs = 4;
        public String color = "white";

        public override void animalSound()
        {
            Console.WriteLine("Woof!! Sounds like a dog!");
        }

    }


}