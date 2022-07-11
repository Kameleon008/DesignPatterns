using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy.Components.StrategyDisplay
{
    internal class StrategyDisplayAsText : IStrategyDisplay
    {
        public void Display()
        {
            Console.WriteLine("Displayed as text");
        }
    }
}
