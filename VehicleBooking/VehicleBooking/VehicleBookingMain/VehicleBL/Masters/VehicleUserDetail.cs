using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleBL.Masters
{
    public class VehicleUserDetail
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int UserId { get; set; }
        public string UserType { get; set; } // Driver/Assistant/Conductor
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DeActiveDate { get; set; }
    }
}
