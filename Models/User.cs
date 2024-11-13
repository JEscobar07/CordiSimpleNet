
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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Column("name")]
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Column("email")]
        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        [Column("password")]
        [Required]
        [MaxLength(100)]
        public string Password { get; set; }

        [Column("role_id")]
        [Required]
        public int Role_id {get; set;}

        [ForeignKey("Role_id")]
        public Rol Rol {get; set;}
    }
}