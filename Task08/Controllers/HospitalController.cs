using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task08.DTOs;
using Task08.Repositories.Interfaces;

namespace Task08.Controllers
{
    [Route("api/hospital")]
    [ApiController]
    [Authorize]
    public class HospitalController : ControllerBase
    {
        private readonly IHospitalDbRepository repository;

        public HospitalController(IHospitalDbRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet("doctors")]
        public async Task<IActionResult> GetDoctors()
        {
            var result = await repository.GetDoctorsAsync();

            if (result == null)
                return NoContent();

            return Ok(result);
        }

        [HttpPost("doctors")]
        public async Task<IActionResult> AddDoctor([FromBody] DoctorDto dto)
        {
            var result = await repository.AddDoctorAsync(dto);

            if (result != "Success!")
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPut("doctors/{id}")]
        public async Task<IActionResult> ChangeDoctor([FromRoute] int id, [FromBody] DoctorDto dto)
        {
            var result = await repository.ChangeDoctorAsync(id, dto);

            if (result != "Success!")
                return NotFound(result);

            return Ok(result);
        }

        [HttpDelete("doctors/{id}")]
        public async Task<IActionResult> DeleteDoctor([FromRoute] int id)
        {
            var result = await repository.DeleteDoctorAsync(id);

            if (result != "Success!")
                return BadRequest(result);

            return Ok(result);
        }

        [HttpGet("prescriptions/{id}")]
        public async Task<IActionResult> GetPrescription([FromRoute] int id)
        {
            var result = await repository.GetPrescriptionAsync(id);

            if (result == null)
                return NoContent();

            return Ok(result);
        }
    }
}
