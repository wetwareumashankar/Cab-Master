using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleBL.Masters
{
    public class VehicleTypeMaster
    {
        public int VehicleTypeId { get; set; }
        public string VehicleTypeName { get; set; }
        public string Capacity { get; set; }
        public string ExtraCapacity { get; set; }
        public string ServiceType { get; set; }
        public string LuggageCapacity { get; set; }
        public string Remarks { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
