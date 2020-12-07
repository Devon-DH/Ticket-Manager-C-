
//Name: Devon Henry
//Class: 1322LW02
//Assingment6
using System;
namespace LAssignment6
{
    public class AdvancedBooking: ticket
    {
        public AdvancedBooking() : base()
        {
       
            setTicketType("advanced");



        }
        public AdvancedBooking(string tickettype, int ticketprice) : base(tickettype, ticketprice, 0)
        {


            setTicketprice(ticketprice);
            setTicketType(tickettype);



        }
        public override int getPrice()
        {
           
            return ticketprice;
        }

        public void setTicketprice()
        {
            if (numDaysUntilGame < 15) {
                ticketprice = 50;
            }
            else
            {
                ticketprice = 25;
            }


                
            this.ticketprice = ticketprice;
        }

       
        public void SetnumDaysUntilGame(int numDaysUntilGame)
        {
            this.numDaysUntilGame = numDaysUntilGame;
        }

        public override string ToString()
        {
            return "You sold: Ticket number " + ticketnum + " with a price of $" + ticketprice + " for a game in  " + numDaysUntilGame + " days.";

        }
    }
}
