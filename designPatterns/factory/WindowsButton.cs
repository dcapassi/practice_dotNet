using System;

namespace factory
{
    class WindowsButton : IButton
    {
        public void render()
        {
            Console.WriteLine("Rendering a Windows Button!");
        }
    }
}