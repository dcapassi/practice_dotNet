using System;

namespace observer
{
    class PrintUserUpperCase : Observer
    {
        public void update(Object user)
        {
            Console.Write("Printing the last created user in upper case: ");
            Console.WriteLine((user as User).name.ToUpper());
        }
    }
}
