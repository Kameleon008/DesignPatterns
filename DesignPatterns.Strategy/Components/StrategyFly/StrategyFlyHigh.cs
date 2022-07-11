using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy.Components.StrategyFly
{
    internal class StrategyFlyHigh : IStrategyFly
    {
        public void Fly()
        {
            Console.WriteLine("Fly High");
        }
    }
}
