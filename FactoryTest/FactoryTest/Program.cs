using System;
using System.Collections.Generic;

namespace FactoryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var fabriekske = new RecipientFactory();
            var ccAddress = fabriekske.CreateRecipient(RecipientType.CC, "jean-claude@telenet.be");
            var bccAddress = fabriekske.CreateRecipient(RecipientType.BCC, "jean-claudine@telenet.be");
            var emailAddress = fabriekske.CreateRecipient(RecipientType.EMAIL, "jeannette-claudine@telenet.be");

            List<Recipient> recipients = new List<Recipient>{ ccAddress, bccAddress, emailAddress };

            foreach(var r in recipients)
            {
                Console.WriteLine($"Created a recipient of type {r.GetType()} with the address: {r.Address}");
            }
        }
    }
}
