using Assignment_04_OOP.BookingTicket;
using Assignment_04_OOP.BookingTicket.Inheritance;
using System.Numerics;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_04_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region PART 01
            //// Part 01


            //  Question 01 :

            //          Static Binding(Early Binding) 
            //                 =>  compile time




            //          Dynamic Binding(Late Binding)
            //                    => run time





            //  Question 02 :

            //          Method Overloading : Same method name, different parameter lists — within the same class. Resolved at compile time.



            //          Method Overriding : Derived class overrides a virtual method from the base class using the override keyword.




            // Question 03 :



            //            virtual → Allows a method to be override in a child class.

            //            override → Used in a child class to redefine a method.

            //            sealed → Prevents any other class from overriding it.

            #endregion


            Cinema cinema = new Cinema();
            cinema.OpenCinema();



            Console.WriteLine("\n========== SetPrice Test ==========");


            StandardTicket t1 = new StandardTicket("Inception", 120, "A-5");


            Console.WriteLine("Setting price directly: 150");
            t1.SetPrice(150);


            Console.WriteLine("Setting price with multiplier: 100 x 1.5 = 150");
            t1.SetPrice(100, 1.5m);


            VIPTicket t2 = new VIPTicket("Avengers", 200, true);
            IMAXTicket t3 = new IMAXTicket("Dune", 180, false);



            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);

            cinema.PrintAllTickets();

            ProcessTicket(t2);

            cinema.CloseCinema();
        }



        static void ProcessTicket(Ticket t)
        {
            Console.WriteLine("\n========== Process Single Ticket ==========");
            t.PrintTicket();
        }





   
    }
}
