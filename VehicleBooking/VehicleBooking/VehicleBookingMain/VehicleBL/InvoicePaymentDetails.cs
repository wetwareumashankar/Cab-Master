using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleBL
{
    public class InvoicePaymentDetails
    {
        public long InvoiceDetailId { get; set; }
        public long InvoiceId { get; set; }
        public decimal TotalPayable { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal BalanceAmount { get; set; }
        public string Remaks { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
