using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task07.Models;
using Task07.Repositories.Interfaces;

namespace Task07.Repositories.Implementations
{
    public class ClientDbReposiitory : IClientDbRepository
    {
        private readonly s20363Context context;

        public ClientDbReposiitory(s20363Context context)
        {
            this.context = context;
        }

        public async Task DeleteClientAsync(int idClient)
        {
            bool hasTrips = await context.ClientTrips.AnyAsync(row => row.IdClient == idClient);

            if (hasTrips) throw new Exception("Client has one or more trips!");

            Client client = await context.Clients.Where(row => row.IdClient == idClient).FirstOrDefaultAsync();
            context.Remove(client);

            await context.SaveChangesAsync();
        }
    }
}
