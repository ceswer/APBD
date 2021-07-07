using FinalTask.DTOs;
using FinalTask.Enums;
using FinalTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalTask.Repositories.Interfaces
{
    public interface IDbRepository
    {
        Task<ArtistDto> GetArtistAsync(int id);
        Task<DbAnswer> ChangeAsync(int idArt, int idEv, NewDateDto newDate);
    }
}
