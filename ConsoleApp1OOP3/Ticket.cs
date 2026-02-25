using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1OOP3
{
    public class Ticket
    {
        private static int _ticketCounter = 0;
        public string movieName { get; set; }
        private decimal _price;
        public decimal Price
        {
            get=> _price;
            set
            { 
            if (value < 0)
                {
                    Console.WriteLine("Price cannot be negative.");
                }
                _price = value;
            }
        }
        public int Ticketid {get; }
        public Ticket(string movieName, decimal price)
        {
            this.movieName = movieName;
            this.Price = price;
            this.Ticketid = ++_ticketCounter;
        }
        public decimal PriceAfterTax=> Price * 1.14m;
        public override string ToString()
        {
            return $"Ticket ID: {Ticketid}, Movie Name: {movieName}, Price: {Price:EGP}, Price After Tax: {PriceAfterTax:C}";
        }
        public static int GetTotalTickets()
        {
            return _ticketCounter;
        }

    }
}
