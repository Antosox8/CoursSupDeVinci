using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoursSupDeVinci;

[Table("detail")]
public class Detail
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }
    
    [Required]
    //relation n..n vers Detail
    public ICollection<Person> Persons { get; set; } = new List<Person>();

    public Detail(string street, String zipCode, string city)
    {
        this.Street = street;
        this.ZipCode = zipCode;
        this.City = city;
    }
    
    [Column("street")]
    public string Street
    {
        get;
        set;
    }

    
    [Column("zipcode")]
    public String ZipCode
    {
        get;
        set;
    }

    [Column("city")]
    public string City
    {
        get;
        set;
    }
}