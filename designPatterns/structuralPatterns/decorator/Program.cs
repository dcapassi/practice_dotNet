using System;

namespace decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage1 = new DarkRoast();
            beverage1 = new Mocha(beverage1);
            beverage1 = new Whip(beverage1);

            Beverage beverage2 = new Decaf();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);

            Console.WriteLine(beverage1.getDescription());
            Console.WriteLine(beverage2.getDescription());


        }
    }
}
