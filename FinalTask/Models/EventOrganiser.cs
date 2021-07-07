using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalTask.Models
{
    public class EventOrganiser
    {
        public int IdEvent { get; set; }
        public int IdOrganiser { get; set; }

        public virtual Event IdEventNav { get; set; }
        public virtual Organiser IdOrganiserNav { get; set; }
    }
}
