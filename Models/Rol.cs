using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CordiSimpleNet.Models
{

    [Table("roles")]
    public class Rol
    {
        //Attributes
        
        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set;}

        [Column("name")]
        [MaxLength(100)]
        [Required]
        public string Name {get; set;}

        [Column("description")]
        [MaxLength(150)]
        public string Description {get; set;}
    }
}