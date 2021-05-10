using System;

namespace factory
{
    class LinuxDialog : Dialog
    {
        public override IButton createButton()
        {
            return new LinuxButton();
        }

    }
}
