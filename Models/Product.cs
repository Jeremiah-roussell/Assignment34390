using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignment3.Models
{
    public class Product
    {
        public int ProductID { get; set; } // primary key
        public string ProductName { get; set; }
        public string Price { get; set; }
        public List<Store> Stores { get; set; } // Navigation property to Stores
    }
}