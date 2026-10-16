using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoursSupDeVinci;

[Table("classes")]
public class Classe
{
    [Key]
    [Column("id")]
    public Guid Id {get;set;}

    [Required]
    [Column("name")]
    public String Name
    {
        get;
        set;
    }

    [Required]
    [Column("level")]
    public String Level
    {
        get;
        set;
    }

    [Required]
    [Column("school")]
    public String School
    {
        get;
        set;
    }

    public List<Person> Persons
    {
        get;
        set;
    }
}