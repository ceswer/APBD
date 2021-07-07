using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task07.Repositories.Interfaces
{
    public interface IClientDbRepository
    {
        Task DeleteClientAsync(int idClient);
    }
}
