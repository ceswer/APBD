using FinalTask.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalTask.Configurations
{
    public class OrganiserConfig : IEntityTypeConfiguration<Organiser>
    {
        public void Configure(EntityTypeBuilder<Organiser> builder)
        {
            builder.HasKey(e => e.IdOrganiser).HasName("Organiser_PK");
            builder.Property(e => e.IdOrganiser).UseIdentityColumn();

            builder.Property(e => e.Name).HasMaxLength(30).IsRequired();

            var list = new List<Organiser>();

            list.Add(new Organiser
            {
                IdOrganiser = 1,
                Name = "Ceswer"
            });

            list.Add(new Organiser
            {
                IdOrganiser = 2,
                Name = "Kowalski"
            });

            list.Add(new Organiser
            {
                IdOrganiser = 3,
                Name = "Piotrowski"
            });

            list.Add(new Organiser
            {
                IdOrganiser = 4,
                Name = "Nazarii"
            });

            list.Add(new Organiser
            {
                IdOrganiser = 5,
                Name = "Sample"
            });

            list.Add(new Organiser
            {
                IdOrganiser = 6,
                Name = "One by one"
            });

            builder.HasData(list);
        }
    }
}
