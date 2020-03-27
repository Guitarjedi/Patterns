using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryTest
{
    public abstract class Recipient
    {
        protected string address = "undefined";
        public string Address => address;
    }
}
