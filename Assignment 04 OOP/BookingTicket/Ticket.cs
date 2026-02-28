using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_OOP.BookingTicket
{
    internal class Ticket
    {

        public string MovieName { get; set; }
        public decimal Price { get; private set; }

        public int TicketId { get; }

        private static int counter = 0;

        public Ticket(string movieName, decimal price)
        {
            if (price <= 0)
            {
                throw new ArgumentException("Price must be greater than zero.");
            }





            MovieName = movieName;
            Price = price;

            counter++;
            TicketId = counter;


        }

        public static int GetTotalTickets()
        {
            return counter;
        }

        public decimal PriceAfterTax()
        {
            return Price * 1.14m;
        }


        public void SetPrice(decimal price)
        {
            if (price > 0)
                Price = price;
        }

        public void SetPrice(decimal basePrice, decimal multiplier)
        {
            if (basePrice > 0 && multiplier > 0)
                Price = basePrice * multiplier;
        }



        public virtual void PrintTicket()
        {
            Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP");
        }


    




    }
}
