using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalTask.DTOs
{
    public class ArtistDto
    {
        public int IdArtist { get; set; }
        public string Nickname { get; set; }

        public ICollection<EventDTO> EventDTOs { get; set; }
    }
}
