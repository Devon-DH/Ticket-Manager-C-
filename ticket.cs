
//Name: Devon Henry
//Class: 1322LW02
//Assingment6

using System;
using System.Collections;
using System.Collections.Generic;

namespace LAssignment6
{
    public abstract class ticket
    {

      
     
        protected static int NextTicketNumber = 1;
        protected int ticketnum = 1;
        protected int ticketprice;
        protected string tickettype;
        protected int numDaysUntilGame;
       
        public ticket()
        {
            ticketnum = NextTicketNumber;
            ticketprice = 50;
            tickettype = "discount";
            numDaysUntilGame = 0;
            NextTicketNumber++;




        }
        public ticket(string tickettype,int ticketprice,  int numDaysUntilGame )
        {
           
            this.tickettype = tickettype;
            this.ticketprice = ticketprice;
            this.ticketnum = NextTicketNumber;
            this.numDaysUntilGame = numDaysUntilGame;
            NextTicketNumber++;


        }

       

        public string getTicketType()
        {
            return tickettype;
        }
        public abstract int getPrice();
        
        public int getTicketnum()
        {
            return ticketnum;
        }
        public int getNextTicketNumber()

        {
            
            return NextTicketNumber;
        }
        public int getnumDaysUntilGame()
        {
            return numDaysUntilGame;
        }
        public void setTicketprice(int ticketprice)
        {
            this.ticketprice = ticketprice;
        }
        public void setTicketType(string tickettype)
        {
            this.tickettype = tickettype;
        }
        public void setTicketnum(int ticketnum)
        {
            this.ticketnum = ticketnum;
        }
        

        
        public void SetnumDaysUntilGame(int numDaysUntilGame)
        {
            this.numDaysUntilGame = numDaysUntilGame;
        }




       

            
       
            public override string ToString() {
            return "You sold: Ticket number " + ticketnum + " with a price of $" + ticketprice + " is a " +tickettype+ " for a game in  " +numDaysUntilGame + "days."; 
 
        }


        

    }
}