using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoursSupDeVinci;

[Table("person")]
public class Person
{
    [Key]
    [Column("id")]
    public Guid Id {get;set;}
    
    [Required]
    //relation n..n vers Detail
    public ICollection<Detail> Details { get; set; } = new List<Detail>();
    
    [Required]
    private int size;

    [ForeignKey("person_classe_fk")]
    [Column("id_classe")]
    public Guid IdClasse {get; set;}
    
    public Classe Classe {get; set;}

    #region Accesseur

    [Required]
    [Column("firstname")]
    public string Firstname
    {
        get;
        set;
    }

    [Required]
    [Column("lastname")]
    public string Lastname
    {
        get;
        set;
    }

    [Required]
    [Column("birthdate")]
    public DateTime Birthdate
    {
        get;
        set;
    }
    
    [Column("size")]
    public int Size
    {
        get;
        set;
    }

    #endregion

    public int getYearsOld()
    {
        DateTime today = DateTime.Today;

        int years = today.Year - Birthdate.Year;

        if (today.Month < Birthdate.Month || today.Month == Birthdate.Month && today.Day < Birthdate.Day)
        {
            years--;
        }
        
        return years;
    }
}