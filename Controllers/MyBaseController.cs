using Microsoft.AspNetCore.Mvc;

namespace MyAPI.Controllers;

public class MyBaseController: ControllerBase
{
    protected readonly ApplicationDbContext database;
    protected readonly IMapper mapper;

    public MyBaseController(ApplicationDbContext database, IMapper mapper)
    {
        this.database = database;
        this.mapper = mapper;
    }
}
