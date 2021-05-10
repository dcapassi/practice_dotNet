using System;
namespace Inheritance
{
    class Cat : Animal
    {

        public int legs = 4;
        public String color = "black";

        public override void animalSound()
        {
            Console.WriteLine("Meooww!! Sounds like a cat!");
        }

    }


}