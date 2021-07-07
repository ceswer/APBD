using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task10.Models;

namespace Task10.EntityTypeConfigurations
{
    public class MovieEntityTypeConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(e => e.ID).HasName("Movie_PK");
            builder.Property(e => e.ID).UseIdentityColumn();

            builder.Property(e => e.Title).HasMaxLength(256).IsRequired();

            builder.Property(e => e.ReleaseDate).IsRequired();

            builder.Property(e => e.Genre).HasMaxLength(128).IsRequired();

            builder.Property(e => e.Price).IsRequired();

            builder.Property(e => e.Rating).HasMaxLength(64);

            var movies = new List<Movie>
            {
                new Movie
                {
                    ID = 1,
                    Title = "The Shawshank Redemption",
                    ReleaseDate = new DateTime(1994, 1, 1),
                    Genre = "Action",
                    Price = 10,
                    Rating = "Good"
                },

                new Movie
                {
                    ID = 2,
                    Title = "The Godfather",
                    ReleaseDate = new DateTime(1972, 1, 1),
                    Genre = "Action",
                    Price = 10,
                    Rating = "Good"
                },

                new Movie
                {
                    ID = 3,
                    Title = "The Godfather: Part II",
                    ReleaseDate = new DateTime(1974, 1, 1),
                    Genre = "Action",
                    Price = 10,
                    Rating = "Good"
                },

                new Movie
                {
                    ID = 4,
                    Title = "The Dark Knight",
                    ReleaseDate = new DateTime(2008, 1, 1),
                    Genre = "Action",
                    Price = 10,
                    Rating = "Good"
                },

                new Movie
                {
                    ID = 5,
                    Title = "12 Angry Men",
                    ReleaseDate = new DateTime(1957, 1, 1),
                    Genre = "Comedy",
                    Price = 10,
                    Rating = "Good"
                },

                new Movie
                {
                    ID = 6,
                    Title = "Schindler's List",
                    ReleaseDate = new DateTime(1993, 1, 1),
                    Genre = "Horror",
                    Price = 10,
                    Rating = "Good"
                },

                new Movie
                {
                    ID = 7,
                    Title = "The Lord of the Rings: The Return of the King",
                    ReleaseDate = new DateTime(2003, 1, 1),
                    Genre = "Action",
                    Price = 10,
                    Rating = "Good"
                },

                new Movie
                {
                    ID = 8,
                    Title = "Pulp Fiction",
                    ReleaseDate = new DateTime(1994, 1, 1),
                    Genre = "Comedy",
                    Price = 10,
                    Rating = "Good"
                },
            };

            builder.HasData(movies);
        }
    }
}
