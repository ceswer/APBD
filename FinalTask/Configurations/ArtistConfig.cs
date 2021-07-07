using FinalTask.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalTask.Configurations
{
    public class ArtistConfig : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.HasKey(e => e.IdArtist).HasName("Artist_PK");
            builder.Property(e => e.IdArtist).UseIdentityColumn();

            builder.Property(e => e.Nickname).HasMaxLength(30).IsRequired();

            var artists = new List<Artist>();

            artists.Add(new Artist
            {
                IdArtist = 1,
                Nickname = "Ceswer"
            });

            artists.Add(new Artist
            {
                IdArtist = 2,
                Nickname = "BullDog"
            });

            artists.Add(new Artist
            {
                IdArtist = 3,
                Nickname = "Nie wiem"
            });

            artists.Add(new Artist
            {
                IdArtist = 4,
                Nickname = "Losowy nickname"
            });

            artists.Add(new Artist
            {
                IdArtist = 5,
                Nickname = "Help me!!!"
            });

            builder.HasData(artists);
        }
    }
}
