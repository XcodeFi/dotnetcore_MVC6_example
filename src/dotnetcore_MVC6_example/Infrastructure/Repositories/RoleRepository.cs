using dotnetcore_MVC6_example.Entities;
using dotnetcore_MVC6_example.Infrastructure.Repositories.Abstract;

namespace dotnetcore_MVC6_example.Infrastructure.Repositories
{
    public class RoleRepository:EntityBaseRepository<Role>,IRoleRepository
    {
        public RoleRepository(GreetingCardContext context) : base(context) { }
    }
}
