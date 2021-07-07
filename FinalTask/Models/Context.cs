using FinalTask.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalTask.Models
{
    public class Context : DbContext
    {
        public Context() { }
        public Context(DbContextOptions<Context> options) : base(options) { }

        public virtual DbSet<Artist> Atist  { get; set; }
        public virtual DbSet<ArtistEvent> AtistEvent { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<EventOrganiser> EventOrganiser { get; set; }
        public virtual DbSet<Organiser> Organiser { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArtistConfig());
            modelBuilder.ApplyConfiguration(new ArtistEventConfig());
            modelBuilder.ApplyConfiguration(new EventConfig());
            modelBuilder.ApplyConfiguration(new EventOrganiserConfig());
            modelBuilder.ApplyConfiguration(new OrganiserConfig());
        }
    }
}
