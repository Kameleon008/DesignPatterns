using DesignPatterns.Strategy.Components.StrategyDisplay;
using DesignPatterns.Strategy.Components.StrategyFly;
using DesignPatterns.Strategy.Components.StrategyQuack;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class Duck
    {
        private IStrategyDisplay strategyDisplay;
        private IStrategyFly strategyFly;
        private IStrategyQuack strategyQuack;

        public Duck(IStrategyDisplay strategyDisplay,IStrategyFly strategyFly, IStrategyQuack strategyQuack)
        {
            this.strategyQuack = strategyQuack; 
            this.strategyDisplay = strategyDisplay; 
            this.strategyFly = strategyFly; 
        }

        public void Display()
        {
            this.strategyDisplay.Display();
        }

        public void Fly()
        {
            this.strategyFly.Fly();
        }

        public void Quack()
        {
            this.strategyQuack.Quack();
        }
    }
}
