using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            Veterinarian veterinarian = new Veterinarian();

            veterinarian.checkHowItSounds(animal: dog);
            veterinarian.checkHowItSounds(animal: cat);



        }
    }
}
