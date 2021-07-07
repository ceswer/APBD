using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task07.Repositories.Interfaces;

namespace Task07.Controllers
{
    [Route("api/clients")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientDbRepository repository;

        public ClientController(IClientDbRepository repository)
        {
            this.repository = repository;
        }

        [HttpDelete("{idClient}")]
        public async Task<IActionResult> DeleteClient([FromRoute] int idClient)
        {
            try
            {
                await repository.DeleteClientAsync(idClient);
                return Ok($"Client ID: {idClient} was deleted!");
            } 
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
