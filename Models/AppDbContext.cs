using System;
using Microsoft.EntityFrameworkCore;

namespace PieShop.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Pie> Pies { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

    }
}
