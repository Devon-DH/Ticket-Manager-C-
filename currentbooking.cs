
//Name: Devon Henry
//Class: 1322LW02
//Assingment6
using System;
namespace LAssignment6
{
    public class Currentbooking : ticket
    {
        public Currentbooking() : base()
        {
            setTicketprice(75);
            setTicketType("current");
            
        

        }
        public Currentbooking(string tickettype, int ticketprice ) : base(tickettype, ticketprice, 0)
        {
           

            setTicketprice(ticketprice);
            setTicketType(tickettype);



        }
        public override int getPrice()
        {
          
            ticketprice = 75;
            return ticketprice;
        }

    
    public int getnumDaysUntilGame()
    {
        return numDaysUntilGame;
    }
    public void SetnumDaysUntilGame(int numDaysUntilGame)
    {
        this.numDaysUntilGame = numDaysUntilGame;
    }
        public override string ToString()
        {
            return "You sold: Ticket number " + ticketnum + " with a price of $" + ticketprice + " for today's game.";

        }
    }    
}
