public class Person
{
    private String firstname;

    private String lastname;
    
    private DateTime birthdate;
    
    private List<String> adressDetails;

    public List<String> AdressDetails
    {
        get => adressDetails;
        set => adressDetails = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Firstname
    {
        get => firstname;
        set => firstname = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Lastname
    {
        get => lastname;
        set => lastname = value ?? throw new ArgumentNullException(nameof(value));
    }

    public DateTime Birthdate
    {
        get => birthdate;
        set => birthdate = value;
    }

    public int getYearsOld()
    {
        DateTime today = DateTime.Today;

        int years = today.Year - birthdate.Year;

        if (today.Month < birthdate.Month || today.Month == birthdate.Month && today.Day < birthdate.Day)
        {
            years--;
        }
        
        return years;
    }

    public String getStreet()
    {
        if (adressDetails[0] != null)
        {
            return adressDetails[0];
        }

        return "Pas de Rue connue";
    }
    public String getPostcode()
    {
        if (adressDetails[1] != null)
        {
            return adressDetails[1];
        }
        return "pas de Code Postal connu";
    }
    public String getCity()
    {
        if (adressDetails[2] != null)
        {
            return adressDetails[2];
        }

        return "Pas de Ville connue";
    }
}