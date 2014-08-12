using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleBL.Masters
{
    public class CompanyMaster
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCode { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public string OwnerName { get; set; }
        public string OwnerEmailId { get; set; }
        public string OwnerPhone { get; set; }
        public string CompanyEmailId { get; set; }
        public string CompanyPhoneNo { get; set; }
        public string CompanyWebsite { get; set; }
        public string CompanyAddress { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
