using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryTest.Interfaces
{
    public interface IRecipientFactory
    {
        public Recipient CreateRecipient(RecipientType type, string address);
    }
}
