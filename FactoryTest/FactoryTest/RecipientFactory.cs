using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryTest
{
    public class RecipientFactory : Interfaces.IRecipientFactory
    {
        public Recipient CreateRecipient(RecipientType type, string address)
        {
            switch(type)
            {
                case RecipientType.CC:
                    return new CCRecipient(address);
                case RecipientType.BCC:
                    return new BCCRecipient(address);
                default:
                    return new EmailRecipient(address);

            }
        }
    }
}
