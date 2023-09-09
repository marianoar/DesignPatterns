﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class PreparedDrink // Product
    {
        public List<string> Ingredients { get; set; }
        public int Milk;
        public int Water;
        public decimal Alcohol;

        public string Result;

    }
}
