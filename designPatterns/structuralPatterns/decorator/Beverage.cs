using System;

namespace decorator
{
    public abstract class Beverage
    {
        public string description = "Unknown Bevarage";

        public virtual string getDescription()
        {
            return description;
        }

    }
}
