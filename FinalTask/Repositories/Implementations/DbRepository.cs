using FinalTask.DTOs;
using FinalTask.Enums;
using FinalTask.Models;
using FinalTask.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalTask.Repositories.Implementations
{
    public class DbRepository : IDbRepository
    {
        private readonly Context context;

        public DbRepository(Context context)
        {
            this.context = context;
        }

        public async Task<DbAnswer> ChangeAsync(int idArt, int idEv, NewDateDto newDate)
        {
            var artist = await context.Atist.FindAsync(idArt);

            if (artist == null) return DbAnswer.ArtistNotFound;

            var evente = await context.Event.FindAsync(idEv);

            if (evente == null) return DbAnswer.EventNotFound;

            var artev = await context
                .AtistEvent
                .FirstOrDefaultAsync(e => e.IdEvent == idEv && e.IdArtist == idArt);

            if (artev == null) return DbAnswer.NotFound;

            if (evente.StartDate >= newDate.NEwDate && newDate.NEwDate <= evente.EndDate)
                return DbAnswer.NotSuitableDate;
            else
            {
                artev.PerfomanceDate = newDate.NEwDate;
                await context.SaveChangesAsync();
            }

            return DbAnswer.OK;
        }

        public async Task<ArtistDto> GetArtistAsync(int id)
        {
            var artist = await context.Atist.Where(e => e.IdArtist == id).Select(e => new ArtistDto
            {
                IdArtist = e.IdArtist,
                Nickname = e.Nickname,
                EventDTOs = context.AtistEvent.Where(e => e.IdArtist == id).OrderBy(e => e.IdEventNav.StartDate).Select(e => new EventDTO
                {
                    Name = e.IdEventNav.Name,
                    IdEvent = e.IdEvent,
                    EndDate = e.IdEventNav.EndDate,
                    StartDate = e.IdEventNav.StartDate
                }).ToList()
            }).FirstOrDefaultAsync();

            return artist;

        }
    }
}
