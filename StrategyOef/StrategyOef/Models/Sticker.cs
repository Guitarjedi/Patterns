using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyOef.Models
{
    public class Sticker : Product
    {
        public Sticker(int price)
        {
            base.Price = price;
        }
    }
}
