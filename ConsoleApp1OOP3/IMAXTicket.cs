using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1OOP3
{
    public class IMAXTicket :Ticket
    {
        public bool Is3D { get; set; }
        public IMAXTicket(string movieName, decimal price, bool is3D) : base(movieName, price + (is3D ? 30:0))
        {
            Is3D = is3D;
        }
         public override string ToString()
        {
            return base.ToString() + $", 3D: {(Is3D ? "Yes" : "No")}";
        }
    }
}
