using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OtherNamecpace
{
    /// <summary>
    /// Within an assembly internal is accessible
    /// </summary>
    internal class Messaging
    {
        public Messaging()
        {
            Console.WriteLine("Internal Messaging Class from CS_OtherNamecpace");
        }
    }

    class MessagingNew
    {
        public MessagingNew()
        {
            Console.WriteLine(" MessagingNew Class from CS_OtherNamecpace");
        }
    }
}
