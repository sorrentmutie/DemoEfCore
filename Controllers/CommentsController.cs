namespace MyAPI.Controllers;

[Route("movies/{movieId:int}/comments")]
[ApiController]
public class CommentsController : MyBaseController
{
    public CommentsController(ApplicationDbContext database, IMapper mapper)
        : base(database, mapper)
    {
    }

    [HttpPost]
    public async Task<ActionResult> PostComment(int movieId, [FromBody] CommentCreationDTO commentCreationDTO)
    {
        var comment = mapper.Map<Comment>(commentCreationDTO);
        comment.MovieId = movieId;
        database.Add(comment);
        await database.SaveChangesAsync();
        return Ok();
    }
}       
