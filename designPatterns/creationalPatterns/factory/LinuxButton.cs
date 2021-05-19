using System;

namespace factory
{
    class LinuxButton : IButton
    {
        public void render()
        {
            Console.WriteLine("Rendering a linux Button!");
        }
    }
}
