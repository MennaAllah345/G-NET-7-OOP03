using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_7_OOP03
{
    internal class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; } = 50;

        public VIPTicket(string movie, decimal price, bool lounge)
            : base(movie, price)
        {
            LoungeAccess = lounge;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $" | Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP";
        }
    }
}
