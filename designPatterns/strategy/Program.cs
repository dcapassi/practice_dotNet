using System;

namespace strategy
{
    class Program
    {
        static void Main(string[] args)
        {

            var myStrategySum = new StrategySum();
            var myStrategySubtraction = new StrategySubtraction();

            var myContext = new Context();
            myContext.setStrategy(myStrategySum);
            Console.WriteLine(myContext.executeStrategy(10, 20));

            myContext.setStrategy(myStrategySubtraction);
            Console.WriteLine(myContext.executeStrategy(10, 20));

        }
    }
}
