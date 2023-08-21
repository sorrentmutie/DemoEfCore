namespace MyAPI.Controllers;

[Route("[controller]")]
[ApiController]
public class ActorsController : MyBaseController
{

    public ActorsController(ApplicationDbContext database, IMapper mapper)
        : base(database, mapper)
    {}

    [HttpPost]
    public async Task<ActionResult> PostActor(ActorCreationDTO actor)
    {
        if (actor == null) return BadRequest();
        var newActor = mapper.Map<Actor>(actor);
        database.Add(newActor);
        await database.SaveChangesAsync();
        return Ok();
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ActorDTO>>> GetActors()
    {
        var actors = await database.Actors.ToListAsync();
        return mapper.Map<List<ActorDTO>>(actors);
    }

    [HttpGet("name")]
    public async Task<ActionResult<IEnumerable<ActorDTO>>> GetActorsByName([FromQuery] string name)
    {
        var actors = await database.Actors.Where(x => x.Name.Contains(name)).ToListAsync();
        return mapper.Map<List<ActorDTO>>(actors);
    }

    [HttpGet("dateOfBirth")]
    public async Task<ActionResult<IEnumerable<ActorDTO>>> GetActorsByBirthday(
        DateTime from, DateTime to)
    {
        var actors = await database.Actors
            .Where(x => x.Birthday >= from && x.Birthday <= to)
            .OrderBy(x => x.Name)
            .ThenBy(x => x.Birthday)
            .ToListAsync();
        return mapper.Map<List<ActorDTO>>(actors);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<ActorDTO>> GetActorById(int id)
    {
        var actor = await database.Actors.FirstOrDefaultAsync(x => x.Id == id);
        if (actor == null) return NotFound();
        return mapper.Map<ActorDTO>(actor);
    }

    [HttpGet("idandname")]
    public async Task<ActionResult<IEnumerable<ActorDTO>>> GetActorsByIdAndName()
    {
        var actors =  await database.Actors.Select(
            x => new ActorDTO { Id = x.Id, Name = x.Name }).ToListAsync();
        return actors;
    }
}
