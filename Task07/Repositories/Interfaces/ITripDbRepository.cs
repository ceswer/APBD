using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task07.Models.DTO.Request;
using Task07.Models.DTO.Response;

namespace Task07.Repositories.Interfaces
{
    public interface ITripDbRepository
    {
        Task<IEnumerable<GetTripsResponseDto>> GetTripsAsync();
        Task AddTripToClientAsync(int idTrip, AddTripToClientRequestDto dto);
    }
}
