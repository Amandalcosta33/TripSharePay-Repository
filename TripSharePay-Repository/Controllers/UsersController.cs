using Microsoft.AspNetCore.Mvc;
using TripSharePay_Repository.DTO;
using TripSharePay_Repository.Service;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]


    public class UsersController : ControllerBase
    {
        private readonly IUsersService usersService;

        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        [HttpPost("create")]
        public async Task<string> CreateAcess(CreateAcessDTO createAcessDTO)
        {
            try
            {
                var result = await usersService.CreatFirstAcess(createAcessDTO);
                return result;
            }
            catch (Exception error)
            {
                return (error.Message);
            }

        }

    }
}