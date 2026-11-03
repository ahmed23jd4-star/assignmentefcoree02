using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentefcore02.models
{
    internal class badge
    {
        public int id { get; set; }
        public DateTime issue { get; set; }
        public BadgeTier badgetier { get; set; }
        public int attendid { get; set; }
        public Attendee attendnav{ get; set; }



    }
    public enum BadgeTier
    {
        Standard,
        VIP
    }
}
