using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyOef.Models
{
    public class Game : Product
    {
        public Game(int price)
        {
            base.Price = price;
        }
    }
}
