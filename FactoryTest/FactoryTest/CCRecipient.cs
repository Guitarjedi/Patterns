using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryTest
{
    public class CCRecipient : Recipient
    {
        public CCRecipient(string address)
        {
            base.address = address;
        }
    }
}
