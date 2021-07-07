using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalTask.Models
{
    public class Event
    {
        public Event()
        {
            ArtistEvents = new HashSet<ArtistEvent>();
            EventOrganisers = new HashSet<EventOrganiser>();
        }
        
        public int IdEvent { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual ICollection<ArtistEvent> ArtistEvents { get; set; }
        public virtual ICollection<EventOrganiser> EventOrganisers { get; set; }

    }
}
