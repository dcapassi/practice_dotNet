using System;

namespace decorator
{
    abstract class BaseDecorator : Beverage
    {
        public Beverage beverage;

        public void setBeverage(Beverage beverage)
        {
            this.beverage = beverage;
        }

    }
}
