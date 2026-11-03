using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentefcore02.models
{
    internal class Event
    {
        public int id{ get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? endtime{ get; set; }
        public int MaxAttendees { get; set; }
        public int organizerid{ get; set; }
        public Organizer organizers{ get; set; }

    }
}
