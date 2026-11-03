using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentefcore02.models
{
    internal class Attendee
    {
        public int id { get; set; }
        [MaxLength(150)]
        public string FullName { get; set; }
        [MaxLength(200)]
        public string Email { get; set; }
        [MaxLength(150)]
        public string Streetl { get; set; }
        [MaxLength(100)]
        public string City{ get; set; }
        [MaxLength(50)]
        public string Country { get; set; }
        [MaxLength(20)]
        [Column("zipcode")]
        public string PostalCode { get; set; }
        [NotMapped]
        public string fulladdrese => $"{Streetl}, {City}, {Country}, {PostalCode}";
        public badge badgenav{ get; set; }


    }
}
