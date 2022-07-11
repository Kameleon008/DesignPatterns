using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy.Components.StrategyQuack
{
    internal class IStrategyQuackQuiet : IStrategyQuack
    {
        public void Quack()
        {
            Console.WriteLine("quack...");
        }
    }
}
