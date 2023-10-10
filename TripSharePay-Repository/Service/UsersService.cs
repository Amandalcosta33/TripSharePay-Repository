using TripSharePay_Repository.DTO;

namespace TripSharePay_Repository.Service
{

    public interface IUsersService
    {
       Task<string> CreatFirstAcess(CreateAcessDTO createAcessDTO);

    }
}