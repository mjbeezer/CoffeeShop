using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class CoffeeContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                 @"Server=.\SQLEXPRESS;Database=CoffeeShopDB;Integrated Security=SSPI;");//add-migration CreateEFmvc1 then update-database
        }
    }
}
