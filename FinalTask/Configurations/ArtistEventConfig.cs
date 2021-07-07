using FinalTask.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalTask.Configurations
{
    public class ArtistEventConfig : IEntityTypeConfiguration<ArtistEvent>
    {
        public void Configure(EntityTypeBuilder<ArtistEvent> builder)
        {
            builder.HasKey(e => new
            {
                e.IdArtist,
                e.IdEvent
            }).HasName("ArtistEvent_PK");

            builder.ToTable("Artist_Event");

            builder.Property(e => e.PerfomanceDate).IsRequired();

            builder.HasOne(e => e.IdArtistNav)
                .WithMany(e => e.ArtistEvents)
                .HasForeignKey(e => e.IdArtist)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Artist_Event_PK");

            builder.HasOne(e => e.IdEventNav)
                .WithMany(e => e.ArtistEvents)
                .HasForeignKey(e => e.IdEvent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Event_Artist_PK");

            var list = new List<ArtistEvent>();

            list.Add(new ArtistEvent
            {
                IdArtist = 1,
                IdEvent = 1,
                PerfomanceDate = DateTime.Now.AddDays(-20)
            });

            list.Add(new ArtistEvent
            {
                IdArtist = 2,
                IdEvent = 2,
                PerfomanceDate = DateTime.Now.AddDays(-20)
            });

            list.Add(new ArtistEvent
            {
                IdArtist = 1,
                IdEvent = 2,
                PerfomanceDate = DateTime.Now.AddDays(-20)
            });

            list.Add(new ArtistEvent
            {
                IdArtist = 2,
                IdEvent = 1,
                PerfomanceDate = DateTime.Now.AddDays(-20)
            });

            list.Add(new ArtistEvent
            {
                IdArtist = 1,
                IdEvent = 3,
                PerfomanceDate = DateTime.Now.AddDays(-20)
            });

            list.Add(new ArtistEvent
            {
                IdArtist = 3,
                IdEvent = 1,
                PerfomanceDate = DateTime.Now.AddDays(-20)
            });

            list.Add(new ArtistEvent
            {
                IdArtist = 4,
                IdEvent = 2,
                PerfomanceDate = DateTime.Now.AddDays(-20)
            });

            list.Add(new ArtistEvent
            {
                IdArtist = 2,
                IdEvent = 3,
                PerfomanceDate = DateTime.Now.AddDays(-20)
            });

            builder.HasData(list);
        }
    }
}
