
//Name: Devon Henry
//Class: 1322LW02
//Assingment6
using System;
using System.Collections;

namespace LAssignment6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numDaysUntilGame;
            int choice = 1;
            ArrayList tickets = new ArrayList();
                while (choice != 5) {
                Console.WriteLine("Choose from the following: \n1. Sell a Ticket for a future game \n2. Sell a Ticket for today's game  \n3. Sell a Discount Ticket \n4. Print All Tickets \n5. Quit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("How many days until the game");
                        numDaysUntilGame = Convert.ToInt32(Console.ReadLine());
                         AdvancedBooking ab = new AdvancedBooking();
                        ab.SetnumDaysUntilGame(numDaysUntilGame);
                        tickets.Add(ab);
                        ab.setTicketprice();


                     break;

                    case 2:
                        Currentbooking cb = new Currentbooking();
                        tickets.Add(cb);
                           
                         
                    break;
                    case 3:
                        DiscountBooking db = new DiscountBooking();
                        tickets.Add(db);
                        Console.WriteLine("How many days until the game");
                        numDaysUntilGame = Convert.ToInt32(Console.ReadLine());
                        db.SetnumDaysUntilGame(numDaysUntilGame);


                        break;
                    case 4:
                        foreach (var ticket  in tickets)
                        {
                            Console.WriteLine(ticket);

                        }

                     break;






                        
                }


                    }
        }

    }
}
