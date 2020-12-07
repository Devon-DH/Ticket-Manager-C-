
//Name: Devon Henry
//Class: 1322LW02
//Assingment6
using System;
namespace LAssignment6
{
    public class DiscountBooking : ticket
    {
        public DiscountBooking() : base()
        {
            setTicketprice(75);
            setTicketType("discount");



        }
        public DiscountBooking(string tickettype, int ticketprice) : base(tickettype, ticketprice, 0)
        {


            setTicketprice(ticketprice);
            setTicketType(tickettype);



        }
        public override int getPrice()
        {
            return ticketprice;
        }
        public override string ToString()
        {
            return "You sold: Ticket number " + ticketnum + " with a price of $" + ticketprice + " is a " + tickettype + " for a game in  " + numDaysUntilGame + " days.";

        }

    }




}