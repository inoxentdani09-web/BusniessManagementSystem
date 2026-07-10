using System;
using System.Collections.Generic;
using System.Text;

namespace BusniessManagementSystem.Models
{
    public class OrderDetails
    {
        public int ProductID { get; set; }
        public Decimal UnitPrice { get; set; }
        public int Qty { get; set; }
        public int Discount { get; set; }
    }
}
