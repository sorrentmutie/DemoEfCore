namespace MyAPI.Entities.Configurations;

public class MovieConfiguration : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder.Property(m => m.Title).IsRequired(); // .HasMaxLength(100);
        builder.Property(m => m.ReleaseDate).IsRequired().HasColumnType("date");
    }
}

