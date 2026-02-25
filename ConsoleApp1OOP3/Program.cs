namespace ConsoleApp1OOP3
{
    internal class Program
    {
        static void Main()
        {
            #region Q1
            //a. composition
            //b. association
            //c. inheritance
            //d. aggregation
            //e. dependancy
            #endregion
            #region Q2
            //a. yes can , but object can not access it 
            //b. protected internal : accessible within its own assembly from any class or by derived classes in another assembly.
            //private protected : accessible within its own assembly by derived classes only.
            //c. with class :not inheritance 
            //with method :can not with method directly but use with overridemethod in derived class and privent any override more.
            //d. sealed class privent inheritance but can make object from it because it steal a class .
            #endregion
            Cinema cinema = new Cinema("VOX");

            cinema.OPenCinema();

            Ticket t1 = new StandardTicket("Inception", 120, "A-5");
            Ticket t2 = new VIPTicket("Avengers", 200, true);
            Ticket t3 = new IMAXTicket("Dune", 180, false);

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);

            cinema.PrintAllTickets();

            Console.WriteLine($"\nTotal Tickets Created: {Ticket.GetTotalTickets()}");

            cinema.CloseCinema();

        }
    }
}
