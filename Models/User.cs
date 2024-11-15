
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CordiSimpleNet.Models
{

    [Table("users")]
    public class User
    {

        //Attributes

        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("password")]

        public string Password { get; set; }

        [Column("role_id")]

        public int Role_id {get; set;}

        [ForeignKey("Role_id")]
        public Rol Rol {get; set;}
    }
}