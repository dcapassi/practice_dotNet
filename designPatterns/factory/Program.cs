using System;

namespace factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Dialog myWindowsDialog = new WindowsDialog();
            myWindowsDialog.render();

            Dialog myLinuxDialog = new LinuxDialog();
            myLinuxDialog.render();

        }
    }
}
