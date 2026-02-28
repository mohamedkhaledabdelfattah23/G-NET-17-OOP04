using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_OOP.BookingTicket.Inheritance
{
    internal class VIPTicket : Ticket

    {
        public bool LoungeAccess { get; set; }

        public decimal ServiceFee { get; } = 50;
        public VIPTicket(string movieName, decimal price, bool louAccs) : base(movieName, price + 50)
        {

            LoungeAccess = louAccs;
        }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"  Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP");
        }


    }
}
