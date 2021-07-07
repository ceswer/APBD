using Microsoft.EntityFrameworkCore;
using Task10.EntityTypeConfigurations;

namespace Task10.Models
{
    public class MovieDbContex : DbContext
    {
        public MovieDbContex() { }
        public MovieDbContex(DbContextOptions<MovieDbContex> options) : base(options) { }

        public virtual DbSet<Movie> Movie { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MovieEntityTypeConfiguration());
        }
    }
}
