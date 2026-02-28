using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_OOP.BookingTicket.Inheritance
{
    internal class StandardTicket : Ticket
    {


        public string seatNumber { get; set; }
        public StandardTicket(string movieName, decimal price, string seat) : base(movieName, price)
        {
            seatNumber = seat;

        }
        
        





        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"  Seat: {seatNumber}");
        }

    }
}
