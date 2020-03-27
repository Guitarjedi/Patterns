using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryTest
{
    public class EmailRecipient : Recipient
    {
        public EmailRecipient(string address)
        {
            base.address = address;
        }
    }
}
