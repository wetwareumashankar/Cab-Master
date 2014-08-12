using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleBL.Masters
{
    public class AreaMaster
    {
        public long AreaId { get; set; }
        public int CityId { get; set; }
        public string AreaName { get; set; }
        public string ZipCode { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public DateTime CreatedDate { get; set; }

        public string CountryName { get; set; }
        public string StateName { get; set; }
        public string DistrictName { get; set; }
        public string CityName { get; set; }
    }
}
