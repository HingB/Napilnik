using System;

namespace Store
{
    public class Order
    {
        public string Paylink { get; private set; }

        public Order(string payLink)
        {
            Paylink = payLink;
        }
    }
}
