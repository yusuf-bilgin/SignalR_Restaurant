using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SignalR_Restaurant.EntityLayer.Entities;

namespace SignalR_Restaurant.DataAccessLayer.Concrete
{
    public class RestaurantContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=YUSUF_BILGIN\\SQLEXPRESS; Initial Catalog=SignalR_RestaurantDB; integrated security=true; TrustServerCertificate=True;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SocialMedia> SocialMedias{ get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<CashRegister> CashRegisters { get; set; }
        public DbSet<RestaurantTable> RestaurantTables { get; set; }
    }
}
