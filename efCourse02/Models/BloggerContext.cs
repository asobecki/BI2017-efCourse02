using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace efCourse02.Models
{
    public class BloggerContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<UserProfile> Users { get; set; }

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySql(@"Server=localhost;database=BiznesEF02;uid=root;pwd=example");
        */
        public BloggerContext(DbContextOptions<BloggerContext> options) : base(options)
        {

        }
    }
}
