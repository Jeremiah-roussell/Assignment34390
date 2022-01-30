using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Assignment3.Models{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider){
            using(var context= new DeliveryCartDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<DeliveryCartDbContext>>()))
            {
                if(context.Customers.Any())
                {
                    return;
                }

                context.Customers.AddRange(
                    new Customer
                    {
                        FirstName="Feilim", LastName= "Clemens", Email="Feilim.Clemens@notreal.com", Address="53 Rocky River Ave. ",City="Michigan City", State="IN", Zipcode=46360

                    },
                     new Customer
                    {
                        FirstName="Antonia", LastName= "Andrews",Email="Antonia.Andrews@notreal.com", Address="56 Middle River Drive ",City="Leominster",State="MA", Zipcode=01453

                    },
                     new Customer
                    {
                        FirstName="Paula", LastName= "Ruiz",Email="Paula.Ruiz@notreal.com", Address="7 Saxton Ave. ",City="Georgetown", State="SC", Zipcode=29440

                    },
                     new Customer
                    {
                        FirstName="Phillip", LastName= "Rodriquez",Email="Phillip.Rodriquez@notreal.com", Address="5 Washington Ave.",City="Dearborn", State="MI", Zipcode=48124

                    },
                     new Customer
                    {
                        FirstName="Miranda ", LastName= "Smith ",Email="Miranda.Smith@notreal.com", Address="9 Miller Dr.",City="Upper Marlboro",State="MD", Zipcode=20772

                    }
                );
                context.Drivers.AddRange(
                    new Driver
                    {
                        FirstName="Sophie", LastName="Douglas", License=" L-380Q", LicensePlate="E 773817", Phone=509-569-2416

                    },
                    new Driver
                     
                    {
                        FirstName="Megan", LastName="Nelson", License="L-627n", LicensePlate="6B 214272", Phone=415-822-4782

                    },
                    new Driver
                     
                    {
                        FirstName="Russell", LastName="Diaz", License="L-871X", LicensePlate="1T 730283", Phone=337-630-6243

                    }
                );
                context.Products.AddRange(
                    new Product{
                        ProductName="Chicken", Price="$8.99"
                    },
                     new Product{
                        ProductName="Steak", Price="$10.00"
                    },
                     new Product{
                        ProductName="Pork", Price="$9.50"
                    },
                     new Product{
                        ProductName="ToothPaste", Price="$6.00"
                    },
                     new Product{
                        ProductName="MouthWash", Price="$3.00"
                    },
                     new Product{
                        ProductName="Asprin", Price="$5.00"
                    },
                     new Product{
                        ProductName="Apple", Price="$2.00"
                    },
                     new Product{
                        ProductName="Banna", Price="$.50"
                    },
                     new Product{
                        ProductName="Orange", Price="$1.50"
                    },
                     new Product{
                        ProductName="Corn", Price="$5.50"
                    },
                     new Product{
                        ProductName="Spinach", Price="$7.87"
                    },
                     new Product{
                        ProductName="Carrots", Price="$4.99"
                    },
                     new Product{
                        ProductName="Milk", Price="2.99"
                    },
                     new Product{
                        ProductName="Yogurt", Price="$4.99"
                    },
                     new Product{
                        ProductName="Cheese", Price="$6.70"
                    }

                );
                
                context.Stores.AddRange(
                    new Store{
                        Name="Kroger", Address="1208 E Bethany Dr.", City="Allen", State="Texas",Zipcode=75002, Phone=972-767-9675
                    },
                    new Store{
                        Name="WalMart", Address="1508 E Lucas Dr.", City="Lucas", State="Texas",Zipcode=76795, Phone=469-898-6519
                    }
                );
            }
            
  
        }
        
    }
}