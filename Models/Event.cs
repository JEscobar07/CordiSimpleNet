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

    public string Name { get; set; }

    [Column("description")]
    public string Description { get; set; }

    [Column("date_start")]

    public DateTime Date_start { get; set; }

    [Column("date_end")]
    public DateTime Date_end { get; set; }

    [Column("location")]

    public string Location { get; set; }

    [Column("max_slots")]
    public int Max_slots { get; set; }

    [Column("occupied_slots")]

    public int Occupied_slots { get; set; }

    [Column("status")]
    public bool Status {get; set;}
}