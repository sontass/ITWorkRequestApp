using ITWorkRequest.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ITWorkRequest.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<StatusList> StatusLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StatusList>( s => {
				s.Property(s => s.StatusCode).IsRequired().HasMaxLength(15);				
                s.Property(s => s.StatusName).HasMaxLength(255);
				}
			);

            modelBuilder.Entity<StatusList>( s => s.HasKey( s => s.StatusCode));
        }
    }
}