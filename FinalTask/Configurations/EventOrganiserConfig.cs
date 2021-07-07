using FinalTask.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalTask.Configurations
{
    public class EventOrganiserConfig : IEntityTypeConfiguration<EventOrganiser>
    {
        public void Configure(EntityTypeBuilder<EventOrganiser> builder)
        {
            builder.HasKey(e => new
            {
                e.IdOrganiser,
                e.IdEvent
            }).HasName("EventOrganiser_PK");

            builder.ToTable("Event_Organiser");

            builder.HasOne(e => e.IdOrganiserNav)
                .WithMany(e => e.EventOrganisers)
                .HasForeignKey(e => e.IdEvent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Organiser_Event_PK");

            builder.HasOne(e => e.IdEventNav)
                .WithMany(e => e.EventOrganisers)
                .HasForeignKey(e => e.IdEvent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Event_Organiser_PK");

            var list = new List<EventOrganiser>();

            list.Add(new EventOrganiser
            {
                IdEvent = 1,
                IdOrganiser = 1
            });

            list.Add(new EventOrganiser
            {
                IdEvent = 2,
                IdOrganiser = 2
            });

            list.Add(new EventOrganiser
            {
                IdEvent = 2,
                IdOrganiser = 1
            });

            list.Add(new EventOrganiser
            {
                IdEvent = 1,
                IdOrganiser = 2
            });

            list.Add(new EventOrganiser
            {
                IdEvent = 3,
                IdOrganiser = 2
            });

            builder.HasData(list);
        }
    }
}
