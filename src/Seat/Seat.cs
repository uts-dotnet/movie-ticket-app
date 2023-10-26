using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketApp
{
    public class Seat
    {
        public string Name { get; set; }

        public Seat()
        {
            Name = string.Empty;
        }

        public Seat(string name)
        {
            this.Name = name;
        }
    }
}
