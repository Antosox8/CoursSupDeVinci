namespace CoursSupDeVinci;

public class Classe
{
    private string name;
    private string level;
    private string school;
    private List<Person> persons;

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Level
    {
        get => level;
        set => level = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string School
    {
        get => school;
        set => school = value ?? throw new ArgumentNullException(nameof(value));
    }

    public List<Person> Persons
    {
        get => persons;
        set => persons = value ?? throw new ArgumentNullException(nameof(value));
    }
}