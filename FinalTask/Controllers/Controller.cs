using FinalTask.DTOs;
using FinalTask.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalTask.Controllers
{
    [Route("api/party")]
    [ApiController]
    public class Controller : ControllerBase
    {
        private readonly IDbRepository repository; 

        public Controller(IDbRepository repository)
        {
            this.repository = repository;
        }


        [HttpGet("artists/{id}")]
        public async Task<IActionResult> GetArtist([FromRoute] int id)
        {
            var artist = await repository.GetArtistAsync(id);

            if (artist == null)
                return NotFound("Sorry, there is no such artist");

            return Ok(artist);
        }


        [HttpPost("artists/{idArt}/event/{idEv}")]
        public async Task<IActionResult> Change([FromRoute] int idArt, [FromRoute] int idEv, [FromBody] NewDateDto newDateDto)
        {
            var answer = await repository.ChangeAsync(idArt, idEv, newDateDto);

            switch (answer)
            {
                case Enums.DbAnswer.NotSuitableDate:
                    return BadRequest("Date is not suitable");
                    break;
                case Enums.DbAnswer.OK:
                    return Ok("Changed");
                    break;
                default:
                    return NotFound("Artist or event not found! or its relatioship");
            }

            return Ok();
        }


    }
}
