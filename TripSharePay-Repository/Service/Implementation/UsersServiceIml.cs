
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using TripSharePay_Repository.Data.Entites;
using TripSharePay_Repository.DTO;

namespace TripSharePay_Repository.Service.Implementation
{
    public class UsersServiceIml : BaseContext, IUsersService
    {

        public UsersServiceIml(RepositoryContext dbContext) : base(dbContext)
        {
        }

        public async Task<string> CreatFirstAcess(CreateAcessDTO createAcessDTO)
        {
            try
            {
                users exist = dbContext.users.Where(u => u.cpf == createAcessDTO.Cpf).FirstOrDefault();

                if (exist != null) { throw new Exception("Usuario já existe, faça login"); }

                users createNewUser = new users(
                    user_name: createAcessDTO.User_name,
                    name: createAcessDTO.Name,
                    user_birthday: createAcessDTO.UserBirthday,
                    senha: createAcessDTO.Senha,
                    cpf : createAcessDTO.Cpf
                );

                await dbContext.AddAsync(createNewUser);
                await dbContext.SaveChangesAsync();

                return (" User created" + createAcessDTO.User_name);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<string> CreatFirstAcess(CreateAcessDTO createAcessDTO)
        {



        }

    }
}
