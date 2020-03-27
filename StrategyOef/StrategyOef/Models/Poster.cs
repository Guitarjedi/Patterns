using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyOef.Models
{
    public class Poster : Product
    {
        public Poster(int price)
        {
            base.Price = price;
        }
    }
}
