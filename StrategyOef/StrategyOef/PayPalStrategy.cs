using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyOef
{
    public class PayPalStrategy : Interfaces.IPaymentStrategy
    {
        private string _username = "GuitarJedi";
        private string _password = "password";
        private bool _loggedIn = false;
        public void Pay(int totalPrice)
        {
            Login();
            
            if (_loggedIn)
                Console.WriteLine("Paid with payPal");
            else
                throw new Exception("You are not logged in");
        }
        public void Login()
        {
            while (!_loggedIn)
            {
                Console.Write("Username: ");
                var username = Console.ReadLine();
                if (username != _username)
                    Console.WriteLine("Wrong username");
                else
                {
                    Console.Write("Password: ");
                    var password = Console.ReadLine();
                    if (password != _password)
                        Console.WriteLine("Wrong password");
                    else
                    _loggedIn = true;
                }
            }
        }
    }
}
