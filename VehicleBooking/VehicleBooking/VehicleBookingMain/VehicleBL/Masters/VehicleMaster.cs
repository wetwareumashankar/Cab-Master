using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleBL.Masters
{
    public class VehicleMaster
    {
        public int VehicleId { get; set; }
        public int VehicleTypeId { get; set; }
        public int CompanyId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Model { get; set; }
        public string VehicleNo { get; set; }
        public string Color { get; set; }
        public bool IsActive { get; set; }
    }
}
