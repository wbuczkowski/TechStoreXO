using System;

namespace TechstoreXO.Models
{
    public class Record
    {
        public string Option { get; set; }
        public string WorkOrder { get; set; }
        public string CostCenter { get; set; }
        public string Material { get; set; }
        public string Plant { get; set; }
        public string StorageLocation { get; set; }
        public string Bin { get; set; }
        public double Quantity { get; set; }
        public string Inventory { get; set; }
        public string Vendor { get; set; }
    }
}