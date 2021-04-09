using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task04.Models;
using Task04.Services;
using Task04.Services.Exceptions;

namespace Task04.Controllers
{
    [Route("api/animals")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private readonly IDBService DBService;

        public AnimalsController(IDBService DBService)
        {
            this.DBService = DBService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAnimals([FromQuery] string orderBy)
        {
            List<Animal> animals = null;
            try { animals = DBService.GetAnimals(orderBy); }
            catch (DBNoRowsException) { return NotFound("There is no rows in database!"); }
            catch (NotMatchedColumnNameException) { return BadRequest("You can order only by name, description, category or area!"); }
            return Ok(animals);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAnimal([FromBody] Animal animal)
        {
            try { DBService.CreateAnimal(animal); }
            catch (Exception) { return BadRequest("Entered data is not valid!"); }
            return Ok("Succsesfully created!");
        }

        [HttpPut("{idAnimal}")]
        public async Task<IActionResult> ChangeAnimal([FromRoute] int idAnimal, [FromBody] Animal animal)
        {
            try { DBService.ChangeAnimal(idAnimal, animal); }
            catch (NoExecutedQueryException) { return NotFound($"No such animal found with ID {idAnimal}!"); }
            catch  (Exception) { return BadRequest("Entered data is not valid!");  }
            return Ok("Succsesfully changed!");
        }

        [HttpDelete("{idAnimal}")]
        public async Task<IActionResult> DeleteAnimal([FromRoute] int idAnimal)
        {
            try { DBService.DeleteAnimal(idAnimal); }
            catch (NoExecutedQueryException) { return NotFound($"No such animal found with ID {idAnimal}!"); }
            catch (Exception) { return BadRequest("Entered data is not valid!"); }
            return Ok("Succsesfully deleted!");
        }


    }
}
