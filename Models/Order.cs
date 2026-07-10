using System;
using System.Collections.Generic;
using System.Text;

namespace BusniessManagementSystem.Models
{
    public class Order
    {
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
