using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleFirstFinal2020.Models;
using SampleFirstFinal2020.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleFirstFinal2020.Controllers
{
    [Route("api/animals")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly IDbService DbService;

        public AnimalController(IDbService DbService)
        {
            this.DbService = DbService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAnimals([FromQuery] string orderBy)
        {
            IEnumerable<AnimalForGetting> animals;
            try { animals = await DbService.GetAnimals(orderBy); }
            catch (Exception e) { return BadRequest(e.Message); }
            return Ok(animals);
        }

        [HttpPut]
        public async Task<IActionResult> AddAnimal([FromBody] Animal animal)
        {
            try { await DbService.AddAnimal(animal); }
            catch (Exception e) { return BadRequest(e.Message); }
            return Ok("Succsesfully added!");
        }
    }
}
