using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CordiSimpleNet.DTOS
{
    public class EventDTO
    {

        //Attributes
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }

        [MaxLength(100)]
        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime Date_start { get; set; }

        [Required]
        public DateTime Date_end { get; set; }

        [Required]
        [MaxLength(150)]
        public string Location { get; set; }

        [Required]
        public int Max_slots { get; set; }

        [Required]
        public int Occupied_slots { get; set; }
    }
}