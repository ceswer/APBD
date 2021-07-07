using FinalTask.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalTask.Configurations
{
    public class EventConfig : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(e => e.IdEvent).HasName("IdEvent_PK");
            builder.Property(e => e.IdEvent).UseIdentityColumn();

            builder.Property(e => e.Name).HasMaxLength(100).IsRequired();
            builder.Property(e => e.StartDate).IsRequired();
            builder.Property(e => e.EndDate).IsRequired();

            var list = new List<Event>();

            list.Add(new Event
            {
                IdEvent = 1,
                Name = "EventSample",
                StartDate = DateTime.Now.AddDays(-20),
                EndDate = DateTime.Now.AddDays(20)
            });

            list.Add(new Event
            {
                IdEvent = 2,
                Name = "Hololulu",
                StartDate = DateTime.Now.AddDays(-20),
                EndDate = DateTime.Now.AddDays(20)
            });

            list.Add(new Event
            {
                IdEvent = 3,
                Name = "Ceswer Party",
                StartDate = DateTime.Now.AddDays(-20),
                EndDate = DateTime.Now.AddDays(20)
            });

            list.Add(new Event
            {
                IdEvent = 4,
                Name = "Cant do it faster",
                StartDate = DateTime.Now.AddDays(-20),
                EndDate = DateTime.Now.AddDays(20)
            });

            list.Add(new Event
            {
                IdEvent = 5,
                Name = "Sea Horses Party",
                StartDate = DateTime.Now.AddDays(-20),
                EndDate = DateTime.Now.AddDays(20)
            });

            list.Add(new Event
            {
                IdEvent = 6,
                Name = "For being quick party",
                StartDate = DateTime.Now.AddDays(-20),
                EndDate = DateTime.Now.AddDays(20)
            });

            list.Add(new Event
            {
                IdEvent = 7,
                Name = "One more party",
                StartDate = DateTime.Now.AddDays(-20),
                EndDate = DateTime.Now.AddDays(20)
            });

            builder.HasData(list);
        }
    }
}
