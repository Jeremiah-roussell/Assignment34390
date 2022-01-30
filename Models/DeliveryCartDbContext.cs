using System;
using Microsoft.EntityFrameworkCore;
namespace Assignment3.Models
{
	public class DeliveryCartDbContext : DbContext
	{
		public DeliveryCartDbContext (DbContextOptions<DeliveryCartDbContext> options)
			: base(options)
		{
		}
		public DbSet<Customer> Customers {get; set;}
        public DbSet<Driver> Drivers {get; set;}
        public DbSet<Product> Products {get; set;}
        public DbSet<Shipment> Shipments {get; set;}
        public DbSet<Store> Stores {get; set;}
	}
}