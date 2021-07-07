using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task08.Models;

namespace Task08.Configurations
{
    public class PrescriptionConfig : IEntityTypeConfiguration<Prescription>
    {
        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            builder.HasKey(e => e.IdPrescription).HasName("IdPrescription_PK");
            builder.Property(e => e.IdPrescription).UseIdentityColumn();

            builder.Property(e => e.Date).IsRequired();
            builder.Property(e => e.DueDate).IsRequired();

            builder.HasOne(e => e.IdDoctorNav)
                .WithMany(e => e.Prescriptions)
                .HasForeignKey(e => e.IdDoctor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Doctor_Prescription_FK");

            builder.HasOne(e => e.IdPatientNav)
                .WithMany(e => e.Prescriptions)
                .HasForeignKey(e => e.IdPatient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Patient_Prescription_FK");

            var prescriptions = new List<Prescription>();

            prescriptions.Add(new Prescription
            {
                IdPrescription = 1,
                Date = DateTime.Now,
                DueDate = DateTime.Now.AddDays(90),
                IdPatient = 1,
                IdDoctor = 1
            });

            prescriptions.Add(new Prescription
            {
                IdPrescription = 2,
                Date = DateTime.Now,
                DueDate = DateTime.Now.AddDays(90),
                IdPatient = 2,
                IdDoctor = 1
            });

            prescriptions.Add(new Prescription
            {
                IdPrescription = 3,
                Date = DateTime.Now,
                DueDate = DateTime.Now.AddDays(90),
                IdPatient = 1,
                IdDoctor = 2
            });

            prescriptions.Add(new Prescription
            {
                IdPrescription = 4,
                Date = DateTime.Now,
                DueDate = DateTime.Now.AddDays(90),
                IdPatient = 1,
                IdDoctor = 3
            });

            prescriptions.Add(new Prescription
            {
                IdPrescription = 5,
                Date = DateTime.Now,
                DueDate = DateTime.Now.AddDays(90),
                IdPatient = 2,
                IdDoctor = 3
            });

            builder.HasData(prescriptions);
        }
    }
}
