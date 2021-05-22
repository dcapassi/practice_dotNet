using System;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            Singleton mySingleton = Singleton.createSingleton();
            Singleton mySingleton1 = Singleton.createSingleton();
            Console.WriteLine("I am a singleton!: " + Convert.ToString(mySingleton == mySingleton1));

            NotSingleton myNotSingleton = NotSingleton.createNotSingleton();
            NotSingleton myNotSingleton1 = NotSingleton.createNotSingleton();
            Console.WriteLine("I am a singleton!: " + Convert.ToString(myNotSingleton == myNotSingleton1));
        }
    }
}
