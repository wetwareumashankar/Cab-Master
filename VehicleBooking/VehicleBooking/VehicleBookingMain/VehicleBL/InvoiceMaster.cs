using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleBL
{
    public class InvoiceMaster
    {
        public long InvoiceId { get; set; }
        public int CompanyId { get; set; }
        public string InvoiceNo { get; set; }
        public long RefferenceId { get; set; }
        public string InvoiceFor { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Vat { get; set; }
        public decimal VatAmount { get; set; }
        public decimal ServiceTax { get; set; }
        public decimal ServiceTaxAmount { get; set; }
        public decimal GrandTotal { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
