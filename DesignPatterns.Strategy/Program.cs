using DesignPatterns.Strategy.Components.StrategyDisplay;
using DesignPatterns.Strategy.Components.StrategyFly;
using DesignPatterns.Strategy.Components.StrategyQuack;
using System;

namespace DesignPatterns.Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStrategyDisplay displayAsText = new StrategyDisplayAsText();
            IStrategyDisplay displayAsGraphic = new StrategyDisplayAsGraphic();

            IStrategyFly flyLow = new StrategyFlyLow();
            IStrategyFly flyHigh = new StrategyFlyHigh();


            IStrategyQuack quackLoud = new StrategyQuackLoud();
            IStrategyQuack quackQuiet = new IStrategyQuackQuiet();


            var fatLoudDuck = new Duck(displayAsText, flyLow, quackLoud);
            var smallQuietDuck = new Duck(displayAsGraphic, flyHigh, quackQuiet);

            Console.WriteLine("");
            Console.WriteLine("--------------------");
            Console.WriteLine("fatLoudDuck:");
            fatLoudDuck.Display();
            fatLoudDuck.Fly();
            fatLoudDuck.Quack();
            Console.WriteLine("--------------------");


            Console.WriteLine("");
            Console.WriteLine("--------------------");
            Console.WriteLine("smallQuietDuck:");
            smallQuietDuck.Display();
            smallQuietDuck.Fly();
            smallQuietDuck.Quack();
            Console.WriteLine("--------------------");


        }
    }
}
