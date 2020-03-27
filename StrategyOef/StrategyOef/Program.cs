using System;
using StrategyOef.Models;
using System.Collections.Generic;
namespace StrategyOef
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product> { new Game(50), new Sticker(15), new Poster(15), new Game(89) };
            var cart = new Cart(products);

            cart.MakePayment(new WalletStrategy());
        }
    }
}
