using Microsoft.EntityFrameworkCore;
using TripSharePay_Repository.Service;
using TripSharePay_Repository.Service.Implementation;

namespace TripSharePay_Repository.IoC
{
    public static class NativeInjectorConfig 
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(options => options.UseMySQL(configuration.GetConnectionString("DbConnection")));

            services.AddScoped<IUsersService, UsersServiceIml>();
           // services.AddScoped<ITokenService, TokenServiceIml>();
           // services.AddScoped<IProductService, ProductServiceIml>();
           // services.AddScoped<IEstablishmentDAO, EstablishmentDAOIml>();
            //services.AddScoped<IProductDAO, ProductDAOIml>();
           // services.AddScoped<IEstablishmentListService, EstablishmentListServiceIml>();
           // services.AddScoped<IValidationService, ValidationServiceIml>();
           // services.AddScoped<IEstablishmentValidationDAO, EstablishmentValidationDAOIml>();
            //services.AddScoped<BaseService, BaseServiceIml>();

        }
    }
}