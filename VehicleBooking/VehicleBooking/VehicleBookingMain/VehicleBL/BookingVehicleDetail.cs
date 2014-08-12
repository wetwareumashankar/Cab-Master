using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleBL
{
    public class BookingVehicleDetail
    {
        public long Id { get; set; }
        public long BookingId { get; set; }
        public int VehicleId { get; set; }
        public int DriverId { get; set; }
        public int Assistant1Id { get; set; }
        public int Assistant2Id { get; set; }
    }
}
