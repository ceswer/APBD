using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task08.Models;

namespace Task08.Configurations
{
    public class DoctorConfig : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(e => e.IdDoctor).HasName("Doctor_PK");
            builder.Property(e => e.IdDoctor).UseIdentityColumn();

            builder.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();

            builder.Property(e => e.Email).HasMaxLength(100).IsRequired();
            builder.HasIndex(e => e.Email).IsUnique();

            // adding data
            var doctors = new List<Doctor>();

            doctors.Add(new Doctor
            {
                IdDoctor = 1,
                FirstName = "Sample",
                LastName = "Doctor",
                Email = "SampleDoctor@gmail.com"
            });

            doctors.Add(new Doctor
            {
                IdDoctor = 2,
                FirstName = "Jakub",
                LastName = "Biologist",
                Email = "JakubBiologist@gmail.com"
            });

            doctors.Add(new Doctor
            {
                IdDoctor = 3,
                FirstName = "Michal",
                LastName = "Pediatrician",
                Email = "MichalPediatrician@gmail.com"
            });

            doctors.Add(new Doctor
            {
                IdDoctor = 4,
                FirstName = "Sergio",
                LastName = "Psychiatrist",
                Email = "SergioPsychiatrist@gmail.com"
            });

            doctors.Add(new Doctor
            {
                IdDoctor = 5,
                FirstName = "Pablo",
                LastName = "Anesthesiologist",
                Email = "PabloAnesthesiologist@gmail.com"
            });

            doctors.Add(new Doctor
            {
                IdDoctor = 6,
                FirstName = "Azucar",
                LastName = "Diabetes",
                Email = "AzucarDiabetes@gmail.com"
            });

            builder.HasData(doctors);
        }
    }
}
