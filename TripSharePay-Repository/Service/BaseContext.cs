using AutoMapper;
namespace TripSharePay_Repository.Service;


    public class BaseContext
    {
        protected readonly RepositoryContext dbContext;
        protected readonly IMapper Mapper;

        public BaseContext(RepositoryContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public BaseContext(RepositoryContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            Mapper = mapper;
        }
    }

