using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1OOP3
{
    public class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; } = 50m;
        public VIPTicket(string movieName, decimal price, bool loungeAccess) : base(movieName, price)
        {
            LoungeAccess = loungeAccess;
        }
        public decimal TotalPrice => Price + ServiceFee;
        public override string ToString()
        {
            return base.ToString() + $", Lounge Access: {(LoungeAccess ? "Yes" : "No")}, Total Price: {TotalPrice:EGP}";
        }
    }
}
