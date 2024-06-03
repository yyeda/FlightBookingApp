using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBooking.models
{
    public class Passenger
    {
        public int SeatNo { get; set; }
        public string Name { get; set; }
        public bool NewPassenger { get; set; }

        public Passenger() { }

        public Passenger(int seatNo, string name, bool newPassenger)
        {
            this.SeatNo = seatNo;
            this.Name = name;
            this.NewPassenger = newPassenger;
        }
    }
}
