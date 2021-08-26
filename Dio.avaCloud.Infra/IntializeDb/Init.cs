using Microsoft.EntityFrameworkCore;
using Dio.avaCloud.Entidades;
using System;

namespace Dio.avaCloud.Infra.IntializeDb
{
    public static class Init
    {
        public static void InitDb(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { 
                    CreateDate = DateTime.Now,
                    Description = "Notebook Avell 32Gb 1 TB SSD", Id = 1, 
                    Price = 4000, 
                    ProductName = "Avell 14400", 
                    Seller = "Avell Brasil" }
            );

        }
    }
}
