using System;

namespace command
{
    class CommandOn : ICommand
    {
        Light light = null;

        public CommandOn(Light light)
        {
            this.light = light;
        }
        public void execute()
        {
            light.On();
        }
    }
}
