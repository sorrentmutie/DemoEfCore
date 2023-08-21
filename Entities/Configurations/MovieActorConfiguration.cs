namespace MyAPI.Entities.Configurations;

public class MovieActorConfiguration: IEntityTypeConfiguration<MovieActor>
{
    public void Configure(EntityTypeBuilder<MovieActor> builder)
    {
        builder.HasKey(ma => new { ma.ActorId, ma.MovieId });
        builder.HasOne(ma => ma.Actor).WithMany(a => a.MoviesActors).HasForeignKey(ma => ma.ActorId);
        builder.HasOne(ma => ma.Movie).WithMany(m => m.MoviesActors).HasForeignKey(ma => ma.MovieId);
    }
}

