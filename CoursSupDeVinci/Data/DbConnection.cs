using Npgsql;

namespace CoursSupDeVinci;

public class DbConnection
{
    public void init()
    {
        var connString = "Host=localhost;Port=5432;Database=postgres;Username=Antoine;Password=Vinci25";
        
        using var conn = new NpgsqlConnection(connString);
        conn.Open();
        Console.WriteLine("Connexion réussie ✅");

        using var cmd = new NpgsqlCommand("SELECT version()", conn);
        var version = cmd.ExecuteScalar();
        Console.WriteLine($"Version PostgreSQL : {version}");
    }

}