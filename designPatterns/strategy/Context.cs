using System;

namespace strategy
{
    class Context
    {
        public IStrategy strategy;

        public void setStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public float executeStrategy(float firstNumber, float secondNumber)
        {
            return this.strategy.execute(firstNumber, secondNumber);
        }


    }
}
