using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleBL.Masters
{
    public class CityMaster
    {
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public string StateName { get; set; }
        public string DistrictName { get; set; }
    }
}
