﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyOef.Models
{
    public abstract class Product
    {
        protected int Price { get; set; }
        public int GetPrice()
        {
            return Price;
        }
    }
}
