using HomeCraft.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeCraft.Data
{
    public class HomeCraftDbContext : DbContext
    {
        public HomeCraftDbContext(DbContextOptions<HomeCraftDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
