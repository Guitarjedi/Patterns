using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryTest
{
    public class BCCRecipient : Recipient
    {
        public BCCRecipient(string address)
        {
            base.address = address;
        }
    }
}
