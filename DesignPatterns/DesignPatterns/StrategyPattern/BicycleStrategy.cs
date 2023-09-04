using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    public class BicycleStrategy : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("soy bicycle strategy running");
        }
    }
}
