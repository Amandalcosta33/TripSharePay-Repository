using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Controllers;
[Route("[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUsersService usersService;

    public UsersController(IUsersService usersService)
    {
        usersService = usersService;
    }

    [HttpPost]
    public string CreateAcess(CreateAcessDTO createAcessDTO)
    {
        var result = usersService.creatFirstAcess(createAcessDTO);
        return ("created");

    }

}