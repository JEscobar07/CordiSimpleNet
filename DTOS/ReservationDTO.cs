using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CordiSimpleNet.DTOS
{
    public class ReservationDTO
    {
        //Attributes

        [Required]
        public int User_id { get; set; }

        [Required]
        public int Event_id { get; set; }
    }
}