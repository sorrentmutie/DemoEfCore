namespace MyAPI.Controllers;

[Route("[controller]")]
[ApiController]
public class MoviesController : MyBaseController
{
    public MoviesController(ApplicationDbContext database, IMapper mapper)
            : base(database, mapper){}

    [HttpGet("{id:int}")]
    public async Task<ActionResult<MovieDTO>> GetMovie(int id) { 
       var movie = await database.Movies
           .Include( x => x.Comments)
           .Include( x => x.Genres)
           .Include( x => x.MoviesActors)
           .ThenInclude(x => x.Actor)
           .FirstOrDefaultAsync(x => x.Id == id);

       if(movie == null)
       {
              return NotFound();
       }

        //   return mapper.Map<MovieDTO>(movie);

        return new MovieDTO
        {
            Comments = mapper.Map<List<CommentDTO>>(movie.Comments),
             Description = movie.Description,
             Director = movie.Director,
             Genres = mapper.Map<List<GenreDTO>>(movie.Genres),
              ImageUrl = movie.ImageUrl,
              InTheaters = movie.InTheaters,
              ReleaseDate = movie.ReleaseDate,
              Title = movie.Title,  
              MovieActors = movie.MoviesActors.Select(x => new MovieActorDTO
              {
                  ActorId = x.ActorId,
                  Character = x.Character,
                  Order = x.Order,
                  ActorName = x.Actor.Name
              }).ToList()
        };

    }


    [HttpPost]  
    public async Task<IActionResult> PostMovie([FromBody] MovieCreationDTO movieCreationDTO)
    {
        var movie = mapper.Map<Movie>(movieCreationDTO);
        if(movie == null)
        {
            return BadRequest();
        }

        if(movie.Genres is not null)
        {
            foreach (var genre in movie.Genres)
            {
                database.Entry(genre).State = EntityState.Unchanged;
            }
        }

        if(movie.MoviesActors is not null)
        {
            for (int i = 0; i < movie.MoviesActors.Count; i++)
            {
                var z = (movie.MoviesActors).ToArray();
                if(z != null)
                {
                    movie.MoviesActors.ElementAt(i).Order = i + 1;  
                }
            }
        }
        database.Add(movie);
        await database.SaveChangesAsync();
        return Ok();
    }
}
