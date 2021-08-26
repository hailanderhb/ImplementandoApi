using Dio.avaCloud.Entidades;
using Dio.avaCloud.Infra.IntializeDb;
using Microsoft.EntityFrameworkCore;

namespace Dio.avaCloud.Infra.Context
{
    public class AvaCloudDb : DbContext
    {
        public AvaCloudDb(DbContextOptions<AvaCloudDb> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.InitDb();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products{get; set;}
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }


    }
}
