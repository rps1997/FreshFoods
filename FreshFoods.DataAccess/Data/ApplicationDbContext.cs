﻿using FreshFoods.Models;
using Microsoft.EntityFrameworkCore;

namespace FreshFoods.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> categories { get; set; }
        public DbSet<BusinessType> businessTypes { get; set; }
    }
}
