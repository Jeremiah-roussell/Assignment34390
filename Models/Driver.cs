using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignment3.Models
{
    public class Driver
    {
        public int DriverID { get; set; } // primary key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string License { get; set; }
        public string LicensePlate {get; set;}
        public int Phone {get; set; }
        public List<Shipment> Shipments {get; set;} // Navigation property to Shipments
    }
}