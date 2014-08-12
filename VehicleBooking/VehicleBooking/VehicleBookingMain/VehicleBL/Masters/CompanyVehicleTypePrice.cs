using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleBL.Masters
{
    public class CompanyVehicleTypePrice
    {
        public int VehiclePriceId { get; set; }
        public int VehicleTypeId { get; set; }
        public string PriceDescription { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }
        public int CompanyId { get; set; }
        public decimal WaitingPrice { get; set; }
        public string WaitingUnit { get; set; }
        public decimal SurchargePrice { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
