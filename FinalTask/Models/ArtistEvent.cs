using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalTask.Models
{
    public class ArtistEvent
    {
        public int IdEvent { get; set; }
        public int IdArtist { get; set; }
        public DateTime PerfomanceDate { get; set; }

        public virtual Artist IdArtistNav { get; set; }
        public virtual Event IdEventNav { get; set; }
    }
}
