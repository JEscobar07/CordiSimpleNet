
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CordiSimpleNet.Models
{

    [Table("reservations")]
    public class Reservation
    {

        //Attributes

        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        [Column("user_id")]

        public int User_id { get; set; }

        [Column("event_id")]

        public int Event_id { get; set; }

        [ForeignKey("User_id")]
        public User User { get; set; }

        [ForeignKey("Event_id")]
        public Event Event { get; set; }
    }
}