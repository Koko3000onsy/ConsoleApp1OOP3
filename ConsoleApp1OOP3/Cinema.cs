using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1OOP3
{
    public class Cinema
    {
        public string CinemaName { get; set; }
        private Projector _projector;
        private Ticket[] _tickets = new Ticket[20];
        public Cinema(string cinemaName)
        {
            CinemaName = cinemaName;
            _projector = new Projector();
        }
        public void AddTicket(Ticket ticket)
        {
            for (int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i] == null)
                {
                    _tickets[i] = ticket;
                    Console.WriteLine($"Ticket added: {ticket}");
                    return;
                }
            }
            Console.WriteLine("Cinema is full. Cannot add more tickets.");
        }
        public void PrintAllTickets()
        {
            Console.WriteLine($"Tickets in {CinemaName}:");
            foreach (var ticket in _tickets)
            {
                if (ticket != null)
                {
                    Console.WriteLine(ticket);
                }
            }
        }
        public void OPenCinema()
        {
            Console.WriteLine($"{CinemaName} is now open!");
            _projector.Start();
        }
        public void CloseCinema()
        {
            Console.WriteLine($"{CinemaName} is now closed!");
            _projector.Stop();
        }
    }
    

    }
