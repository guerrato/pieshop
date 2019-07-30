﻿using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PieShop.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Pie> Pies { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

    }
}
