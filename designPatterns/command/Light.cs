using System;

namespace command
{
    class Light
    {
        public bool isOn = false;

        public void On()
        {
            isOn = true;
        }

        public void Status()
        {
            Console.WriteLine("Light is: " + isOn);
        }
    }
}
