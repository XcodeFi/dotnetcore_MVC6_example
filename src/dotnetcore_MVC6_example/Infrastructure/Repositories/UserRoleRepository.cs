using dotnetcore_MVC6_example.Entities;
using dotnetcore_MVC6_example.Infrastructure.Repositories.Abstract;

namespace dotnetcore_MVC6_example.Infrastructure.Repositories
{
    public class UserRoleRepository: EntityBaseRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(GreetingCardContext context) : base(context) { }
    }
   
}
