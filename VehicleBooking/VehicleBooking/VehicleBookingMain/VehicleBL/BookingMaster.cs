using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleBL
{
    public class BookingMaster
    {
        public long BookingId { get; set; }
        public string BookingRefferenceNo { get; set; } //"CompanyCode/Year/Month/BookingId"
        public int CompanyId { get; set; }
        public int CustomerId { get; set; }
        public long BookingFromAreaId { get; set; }
        public long BookingToAreaId { get; set; }
        public int VehicleTypeId { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime DueDate { get; set; }
        public string BookingStatus { get; set; }
        public string Remarks { get; set; }
    }
}
