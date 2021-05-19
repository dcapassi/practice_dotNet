using System;

namespace decorator
{
    class HouseBlend : BaseDecorator
    {
        public HouseBlend(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", HouseBlend";
        }

    }
}
