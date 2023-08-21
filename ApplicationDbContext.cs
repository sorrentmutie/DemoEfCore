using MyAPI.Seeding;

namespace MyAPI;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        InitialSeeding.Seed(modelBuilder);

        //modelBuilder.Entity<Genre>().Property(g => g.Name).IsRequired(); //.HasMaxLength(150);
        //modelBuilder.Entity<Actor>().Property(a => a.Name).IsRequired(); // .HasMaxLength(150);
        //modelBuilder.Entity<Actor>().Property(a => a.Birthday).HasColumnType("date");
        //modelBuilder.Entity<Actor>().Property(a => a.Salary).HasColumnType("decimal(18,2)");
        //modelBuilder.Entity<Movie>().Property(m => m.Title).IsRequired(); // .HasMaxLength(100);
        //modelBuilder.Entity<Movie>().Property(m => m.ReleaseDate).IsRequired().HasColumnType("date");
        //modelBuilder.Entity<Comment>().Property(c => c.Body).IsRequired().HasMaxLength(500);
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<string>().HaveMaxLength(150);
        base.ConfigureConventions(configurationBuilder);
    }

    public DbSet<Genre> Genres { get; set; } 
    public DbSet<Actor> Actors { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<MovieActor> MovieActors { get; set; }
}
