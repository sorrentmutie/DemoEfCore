namespace MyAPI.Utilities;

public class AutoMapperProfile: Profile
{
    public AutoMapperProfile()
    {
           CreateMap<GenreCreationDTO, Genre>().ReverseMap();
           CreateMap<ActorCreationDTO, Actor>().ReverseMap();
           CreateMap<CommentCreationDTO, Comment>().ReverseMap();
        CreateMap<MovieCreationDTO, Movie>()
          .ForMember(f => f.Genres, 
          options => options.MapFrom
          (x => x.Genres.Select(i => new Genre() {
              Id = i})));
           CreateMap<MovieActorCreationDTO, MovieActor>().ReverseMap();
          // CreateMap<MovieActorDTO, MovieActor>().ReverseMap();
           CreateMap<GenreDTO, Genre>().ReverseMap();
           CreateMap<MovieDTO, Movie>().ReverseMap();          
           CreateMap<ActorDTO, Actor>().ReverseMap();
           CreateMap<CommentDTO, Comment>().ReverseMap();  
    }
}
