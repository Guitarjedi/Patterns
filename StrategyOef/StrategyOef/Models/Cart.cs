using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StrategyOef.Models
{
    public class Cart
    {
        private List<Product> _products;
        public Cart() { }

        public Cart(List<Product> products)
        {
            _products = products;
        }
        public void AddProduct(Product p)
        {
            _products.Add(p);
        }
        public void ClearCart()
        {
            _products.Clear();
        }
        public void MakePayment(WalletStrategy wallet)
        {

            wallet.notEnoughMoney += EventHandler;
            wallet.Pay(TotalPrice());

            void EventHandler(object sender, EventArgs args)
            {
                MakePayment(new PayPalStrategy());
            }

        }
        public void MakePayment(PayPalStrategy payPal)
        {
            payPal.Pay(TotalPrice());
        }
        
        public int TotalPrice()
        {
            return _products.Sum(x => x.GetPrice());
        }
    }
}
