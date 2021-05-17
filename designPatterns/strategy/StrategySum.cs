using System;

namespace strategy
{
    class StrategySum : IStrategy
    {

        public float execute(float firstNumber, float secondNumber)
        {
            return firstNumber + secondNumber;
        }


    }
}
