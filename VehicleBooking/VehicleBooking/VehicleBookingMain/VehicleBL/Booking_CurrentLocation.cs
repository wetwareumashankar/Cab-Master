using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleBL
{
    public class Booking_CurrentLocation
    {
        public long Id { get; set; }
        public long BookingId { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
