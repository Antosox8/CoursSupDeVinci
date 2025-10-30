using CoursSupDeVinci;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

public class SchoolDbContext : DbContext
{
    // --- Tables principales ---
    public DbSet<Classe> Classes { get; set; }
    public DbSet<Person> Persons { get; set; }
    public DbSet<Detail> Details { get; set; }

    // --- Constructeur ---
    public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
        : base(options)
    {
    }
    
    // Constructeur vide pour EF CLI
    public SchoolDbContext() { }

    // --- Configuration des relations ---
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Relation Classe -> Person (1..n)
        modelBuilder.Entity<Person>()
            .HasOne(p => p.Classe)
            .WithMany(c => c.Persons)
            .HasForeignKey(p => p.IdClasse);
    }

    // --- Configuration de la connexion ---
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Charger la configuration manuellement
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile(@"C:\\Users\\julie\\RiderProjects\\CoursSupDeVinci\\CoursSupDeVinci\\appsettings.json", optional: false, reloadOnChange: true)
            .Build();
        
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
        }
    }
}