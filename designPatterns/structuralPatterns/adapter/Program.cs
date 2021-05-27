using System;

namespace adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var hole = new RoundHole(10);
            var plug = new RoundPlug();
            plug.setRadius(9);
            Console.WriteLine("This is supposed to fit: " + hole.fits(plug));

            var plug2 = new SquarePlug();
            plug2.setWidth(15);
            Console.WriteLine("This is shouldn't fit: (I'm expecting a false) " + hole.fits(new SquarePlugAdapter(plug2)));


        }
    }
}
