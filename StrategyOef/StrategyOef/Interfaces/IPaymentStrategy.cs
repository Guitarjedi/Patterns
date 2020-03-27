using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyOef.Interfaces
{
    public interface IPaymentStrategy
    {
        public void Pay(int totalPrice);
    }
}
