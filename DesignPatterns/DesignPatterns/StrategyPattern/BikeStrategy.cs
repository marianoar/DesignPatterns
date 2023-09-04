using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    internal class BikeStrategy : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("bike run method");
        }
    }
}
