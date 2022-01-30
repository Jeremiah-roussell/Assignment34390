using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignment3.Models
{
    public class Shipment
    {
        public int ShipmentID { get; set; } // primary key
        public DateTime ShippingDate { get; set; } = DateTime.Now;
        public int DriverID {get; set;}
        public Driver Driver {get; set;}
        // public List<Driver> Drivers {get; set;} // Navigation property to Drivers
    }
}