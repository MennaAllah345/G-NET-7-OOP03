using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_7_OOP03
{
    internal class Ticket
    {
        private static int counter = 0;

        public string MovieName { get; set; }
        public decimal Price { get; set; }
        public int TicketId { get; }

        public Ticket(string movieName, decimal price)
        {
            if (price <= 0)
                throw new Exception("Price must be greater than 0");

            MovieName = movieName;
            Price = price;

            counter++;
            TicketId = counter;
        }

        public decimal PriceAfterTax
        {
            get { return Price * 1.14m; }
        }

        public static int GetTotalTickets()
        {
            return counter;
        }

        public override string ToString()
        {
            return $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP";
        }

    }
}
