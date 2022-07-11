using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy.Components.StrategyDisplay
{
    internal class StrategyDisplayAsGraphic : IStrategyDisplay
    {
        public void Display()
        {
            Console.WriteLine("Displayed as graphic");
        }
    }
}
