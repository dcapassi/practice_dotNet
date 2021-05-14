using System;

namespace command
{
    class Program
    {
        static void Main(string[] args)
        {
            Light myLight = new Light();
            myLight.Status();
            Invoker myRc = new Invoker();

            Console.WriteLine("Turning the light on!");
            myRc.setCommand(new CommandOn(myLight));
            myRc.executeCommand();
            myLight.Status();

        }
    }
}
