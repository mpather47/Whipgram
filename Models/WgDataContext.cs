using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cellogram.Models
{
    public class WgDataContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        
        public DbSet<Story> StoryDB { get; set; }
        
        
        public WgDataContext(DbContextOptions<WgDataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
