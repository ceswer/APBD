using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalTask.Models
{
    public class Organiser
    {
        public Organiser()
        {
            EventOrganisers = new HashSet<EventOrganiser>();
        }

        public int IdOrganiser { get; set; }
        public string Name { get; set; }

        public virtual ICollection<EventOrganiser> EventOrganisers { get; set; }
    }
}
