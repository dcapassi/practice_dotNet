using System;

namespace strategy
{
    class StrategySubtraction : IStrategy
    {

        public float execute(float firstNumber, float secondNumber)
        {
            return firstNumber - secondNumber;
        }


    }
}
