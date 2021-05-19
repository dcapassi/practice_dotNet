using System;

namespace command
{
    class Invoker
    {
        ICommand slot = null;

        public void setCommand(ICommand command)
        {
            slot = command;
        }


        public void executeCommand()
        {
            slot.execute();
        }



    }
}
