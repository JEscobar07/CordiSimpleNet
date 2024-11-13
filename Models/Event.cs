using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CordiSimpleNet.Models;

[Table("events")]
public class Event
{

    //Attributes
    
    [Column("id")]
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("name")]
    [MaxLength(100)]
    [Required]
    public string Name { get; set; }

    [Column("description")]
    [MaxLength(100)]
    [Required]
    public string Description { get; set; }

    [Column("date_start")]
    [Required]
    public DateTime Date_start { get; set; }

    [Column("date_end")]
    [Required]
    public DateTime Date_end { get; set; }

    [Column("location")]
    [Required]
    [MaxLength(150)]
    public string Location { get; set; }

    [Column("max_slots")]
    [Required]
    public int Max_slots { get; set; }

    [Column("occupied_slots")]
    [Required]
    public int Occupied_slots { get; set; }

    [Column("status")]
    [Required]
    public bool Status {get; set;}
}