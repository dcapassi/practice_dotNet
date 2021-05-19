using System;

namespace factory
{
    abstract class Dialog
    {
        public abstract IButton createButton();

        public void render()
        {
            IButton button = createButton();
            button.render();

        }
    }
}
