using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleBL.Masters
{
    public class DistrictMaster
    {
        public int DistrictId { get; set; }
        //public string CountryName { get; set; }
        public int StateId { get; set; }
        public string StateName { get; set; }
        public string DistrictName { get; set; }
        public bool IsActive { get; set; }
    }
}
