using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignment3.Models
{
    public class Store
    {
        public int StoreID { get; set; } // primary key
        public string Name { get; set; }
        public string Address {get; set;}
        public string City {get; set;}
        public string State {get; set;}
        public int Zipcode {get; set;}
        public int Phone {get; set; }
    }
}