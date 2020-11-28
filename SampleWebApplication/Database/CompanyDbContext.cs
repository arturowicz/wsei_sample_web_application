using Microsoft.EntityFrameworkCore;
using SampleWebApplication.Entities;

namespace SampleWebApplication.Database
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext(DbContextOptions options) : base(options)
        {
            
        }
        
        public DbSet<CompanyEntity> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}