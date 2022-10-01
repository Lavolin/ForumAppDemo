using ForumAppDemo.Data.Configure;
using ForumAppDemo.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ForumAppDemo.Data
{
    public class ForumAppDbContext : DbContext
    {
        public ForumAppDbContext(DbContextOptions<ForumAppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration<Post>(new PostConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Post> Posts  { get; set; }
    }

}
