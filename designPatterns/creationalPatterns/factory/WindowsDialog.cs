using System;

namespace factory
{
    class WindowsDialog : Dialog
    {
        public override IButton createButton()
        {
            return new WindowsButton();
        }

    }
}
