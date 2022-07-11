using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy.Components.StrategyQuack
{
    internal class StrategyQuackLoud : IStrategyQuack
    {
        public void Quack()
        {
            Console.WriteLine("QUACKQUACK!!!!!!");
        }
    }
}
