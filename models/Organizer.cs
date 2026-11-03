using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentefcore02.models
{
    internal class Organizer
    {
        [Key]
        public int id{ get; set; }
        
        [MaxLength(100)]
        [Required]
        public string name{ get; set; }
        [MaxLength(150)]
        public string? CompanyName { get; set; }
        public bool IsVerified { get; set; }
        public OrganizerProfile OrganizerProfilenav { get; set; }
        public HashSet<Event> events = new HashSet<Event>();
    }
}
