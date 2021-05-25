using System;

namespace observer
{
    class PrintUserLowerCase : Observer
    {
        public void update(Object user)
        {
            Console.Write("Printing the last created user in lower case: ");
            Console.WriteLine((user as User).name.ToLower());
        }
    }
}
