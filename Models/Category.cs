using System;
using System.Collections.Generic;
using System.Text;

namespace BusniessManagementSystem.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string  CategoryName { get; set; }
        public string  Descriptipn { get; set; }
        public byte[]? Photo { get; set; }

    }
}
