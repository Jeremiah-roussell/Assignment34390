using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignment3.Models
{
    public class Customer
    {
        public int CustomerID { get; set; } // primary key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address {get; set;}
        public string City {get; set;}
        public string State {get; set;}
        public int Zipcode {get; set;}
        public int Phone {get; set; }
        public List<Shipment> Shipments {get; set;} // Navigation property to Shipments
    }
}