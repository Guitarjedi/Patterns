using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyOef
{
    public class WalletStrategy : Interfaces.IPaymentStrategy
    {
        private double _budget = 50;
        public EventHandler<EventArgs> notEnoughMoney;
        public void Pay(int totalPrice)
        {
            if (_budget > totalPrice)
            {
                Console.WriteLine("Paid using in-game wallet");
                _budget -= totalPrice;
            }
            else
            {
                Console.WriteLine("Not enough money in wallet");
                Console.WriteLine("Try PayPal...");
                var args = new EventArgs();
                notEnoughMoney.Invoke(this, args);
            }
        }
    }
}
