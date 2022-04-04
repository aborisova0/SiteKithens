using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sait.Models
{
    public class KitchenContext : DbContext
    {
        public DbSet<Kitchen> Kitchens { get; set; }
        public DbSet<Feedback> Feedback { get; set; }

        public KitchenContext(DbContextOptions<KitchenContext> options) 
            : base(options)
        {
           Database.EnsureCreated(); 
        }
    }
}