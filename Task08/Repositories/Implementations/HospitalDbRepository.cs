using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task08.DTOs;
using Task08.Models;
using Task08.Repositories.Interfaces;

namespace Task08.Repositories.Implementations
{
    public class HospitalDbRepository : IHospitalDbRepository
    {
        private readonly Context context;

        public HospitalDbRepository(Context context)
        {
            this.context = context;
        }

        public async Task<string> AddDoctorAsync(DoctorDto dto)
        {
            try
            {
                await context.AddAsync(new Doctor
                {
                    FirstName = dto.FirstName,
                    LastName = dto.LastName,
                    Email = dto.Email
                });
                await context.SaveChangesAsync();
            }
            catch (Exception) 
            {
                return "There is a doctor with that email!";
            }

            return "Success!";
        }

        public async Task<string> ChangeDoctorAsync(int id, DoctorDto dto)
        {
            var wantedDoctor = await context.Doctor.FindAsync(id);

            if (wantedDoctor == null)
                return "Can not find the doctor!";

            wantedDoctor.LastName = dto.LastName;
            wantedDoctor.FirstName = dto.FirstName;
            wantedDoctor.Email = dto.Email;

            await context.SaveChangesAsync();

            return "Success!";
        }

        public async Task<string> DeleteDoctorAsync(int id)
        {
            var wantedDoctor = await context.Doctor.FindAsync(id);

            if (wantedDoctor == null)
                return "Can not find the doctor!";

            var isHavingPatiets = await context.Prescription.AnyAsync(e => e.IdDoctor == id);

            if (isHavingPatiets)
                return "Can not delete doctor, because he signed prescriptions to patients!";

            context.Remove(wantedDoctor);
            await context.SaveChangesAsync();

            return "Success!";
        }

        public async Task<IEnumerable<DoctorDto>> GetDoctorsAsync()
        {
            return await context.Doctor.Select(e => new DoctorDto
            {
                FirstName = e.FirstName,
                LastName = e.LastName,
                Email = e.Email
            }).ToListAsync();
        }

        public async Task<PrescriptionDto> GetPrescriptionAsync(int id)
        {
            var wantedPrescription = await context.Prescription.FindAsync(id);

            if (wantedPrescription == null)
                return null;

            PrescriptionDto prescriptionDto = await context
                .Prescription
                .Where(e => e.IdPrescription == id)
                .Select(e => new PrescriptionDto
                {
                    PrescriptionDate = e.Date,
                    PrescriptionDueDate = e.DueDate,
                    PatientFirstName = e.IdPatientNav.FirstName,
                    PatientLastName = e.IdPatientNav.LastName,
                    PatientBirthDate = e.IdPatientNav.BirthDate,
                    DoctorFirstName = e.IdDoctorNav.FirstName,
                    DoctorLastName = e.IdDoctorNav.LastName,
                    DoctorEmail = e.IdDoctorNav.Email,
                    Medicaments = e.PrescriptionMedicaments.Select(e => new MedicamentDto 
                    { 
                        Name = e.IdMedicamentNav.Name,
                        Details = e.Details,
                        Dose = e.Dose
                    })
                }).FirstAsync();
                
            return prescriptionDto;
        }
    }
}
