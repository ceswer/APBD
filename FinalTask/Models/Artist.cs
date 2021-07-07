using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalTask.Models
{
    public class Artist
    {
        public Artist()
        {
            ArtistEvents = new HashSet<ArtistEvent>();
        }

        public int IdArtist { get; set; }
        public string Nickname { get; set; }

        public virtual ICollection<ArtistEvent> ArtistEvents { get; set; }
    }
}
