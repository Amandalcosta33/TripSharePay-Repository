using Microsoft.AspNetCore.Mvc;
using TripSharePay_Repository.DTO;
using TripSharePay_Repository.Service;
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
        var result = usersService.CreatFirstAcess(createAcessDTO);
        return ("created");

    }

}