using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleBL.Masters
{
    public class VehicleUsersMaster
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public string Address { get; set; }
        public string EmailId { get; set; }
        public string PhoneNo { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactNo { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime DeActiveDate { get; set; }
        public bool IsActive { get; set; }
        public string DLNo { get; set; }
        public DateTime DLExpiryDate { get; set; }
        public string AdhaarNo { get; set; }
        public string VoterId { get; set; }
    }
}
